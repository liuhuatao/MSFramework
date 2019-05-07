using MSFramework.DependencyInjection;
using MSFramework.Domain.Repository;

namespace Producting.Domain.Respository
{
	public interface IProductReadRepository : IReadRepository<AggregateRoot.Product>, IScopeDependency
	{
	}


	public interface IProductWriteRepository : IWriteRepository<AggregateRoot.Product>, IScopeDependency
	{
	}
}