using System;
using System.Runtime.InteropServices.ComTypes;
using MSFramework.Domain;

namespace Producting.Domain.AggregateRoot
{
	public class Resource : EntityBase<Guid>
	{
		/// <summary>
		/// 类型：专家和金融科技
		/// </summary>

		public ResourceType Type;

		/// <summary>
		/// 首次或者跟踪资源
		/// </summary>
		public bool IsFirst;

		/// <summary>
		/// 数量
		/// </summary>
		public int Number;

		/// <summary>
		/// 工时
		/// </summary>
		public int Hour;

		/// <summary>
		/// 需求Id
		/// </summary>
		public Requirement Requirement;

		/// <summary>
		/// 锁定价格
		/// </summary>
		public decimal LockPrice;

		/// <summary>
		/// 不锁定价格
		/// </summary>
		public decimal UnLockPrice;


		public Resource(ResourceType type, int number, int hour, Requirement requirement, decimal lockPrice,
			decimal unLockPrice)
		{
			Type = type;
			Number = number;
			Requirement = requirement;
			LockPrice = lockPrice;
			UnLockPrice = unLockPrice;
		}
	}
}