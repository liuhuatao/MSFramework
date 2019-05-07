using MSFramework.Domain;

namespace Producting.Domain.AggregateRoot
{
	public class ResourceType : Enumeration
	{
		/// <summary>
		/// 专家
		/// </summary>
		public static ResourceType Expert = new ResourceType(1, nameof(Expert).ToLowerInvariant());

		/// <summary>
		/// 金融科技
		/// </summary>
		public static ResourceType Technology = new ResourceType(1, nameof(Technology).ToLowerInvariant());

		public ResourceType(int id, string name) : base(id, name)
		{
		}
	}
}