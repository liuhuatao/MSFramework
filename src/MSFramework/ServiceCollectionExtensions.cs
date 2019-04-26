using System;
using System.Linq;
using AspectCore.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using MSFramework.Common;
using MSFramework.DependencyInjection;
using MSFramework.Domain;
using MSFramework.EventBus;
using MSFramework.EventSouring;
using MSFramework.Reflection;
using MSFramework.Serialization;

namespace MSFramework
{
	public static class ServiceCollectionExtensions
	{
		public static MSFrameworkBuilder AddEventHandlers(this MSFrameworkBuilder builder,
			params Type[] types)
		{
			var handlerType = typeof(IEventHandler);
			foreach (var type in types)
			{
				if (handlerType.IsAssignableFrom(type))
				{
					builder.Services.AddScoped(type, type);
				}
				else
				{
					throw new Exception("AddCommandHandler");
				}
			}

			return builder;
		}

		public static MSFrameworkBuilder AddInMemoryEventStore(this MSFrameworkBuilder builder)
		{
			builder.Services.AddSingleton<IEventStore, InMemoryEventStore>();
			return builder;
		}

		public static IServiceProvider AddMSFramework(this IServiceCollection services,
			Action<MSFrameworkBuilder> builderAction = null)
		{
			var builder = new MSFrameworkBuilder(services);
			builderAction?.Invoke(builder);

			//初始化所有程序集查找器，如需更改程序集查找逻辑，请事先赋予自定义查找器的实例
			if (Singleton<IAssemblyFinder>.Instance == null)
			{
				Singleton<IAssemblyFinder>.Instance = new AssemblyFinder();
				builder.Services.AddSingleton(Singleton<IAssemblyFinder>.Instance);
			}

			if (Singleton<IDependencyTypeFinder>.Instance == null)
			{
				Singleton<IDependencyTypeFinder>.Instance = new DependencyTypeFinder();
				var dependencyTypeDict = Singleton<IDependencyTypeFinder>.Instance.GetDependencyTypeDict();
				foreach (var kv in dependencyTypeDict)
				{
					builder.Services.Add(kv.Value, kv.Key);
				}
			}

			if (Singleton<IJsonConvert>.Instance == null)
			{
				Singleton<IJsonConvert>.Instance = new DefaultJsonConvert(new JsonConvertOptions());
				builder.Services.AddSingleton(Singleton<IJsonConvert>.Instance);
			}

			builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
			builder.Services.AddScoped<IMSFrameworkSession, MSFrameworkSession>();
			builder.AddLocalEventBus();

			return services.BuildAspectInjectorProvider();
		}

		public static IApplicationBuilder UseMSFramework(this IApplicationBuilder builder)
		{
			var initializers = builder.ApplicationServices.GetServices<IInitializer>().ToList();
			foreach (var initializer in initializers)
			{
				initializer.Initialize();
			}

			return builder;
		}
	}
}