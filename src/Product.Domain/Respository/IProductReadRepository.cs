using MSFramework.DependencyInjection;
using MSFramework.Domain.Repository;

namespace Product.Domain
{
	public interface IProductReadRepository : IReadRepository<AggregateRoot.Product>, IScopeDependency
	{
	}


	public interface IProductWriteRepository : IWriteRepository<AggregateRoot.Product>, IScopeDependency
	{
	}
}