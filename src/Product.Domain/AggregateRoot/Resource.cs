using System;
using System.Runtime.InteropServices.ComTypes;
using MSFramework.Domain;

namespace Product.Domain.AggregateRoot
{
	public class Resource : EntityBase<Guid>
	{
		/// <summary>
		/// 类型： 专家咨询、线上数据、数据产品、调研、电话、会议、路演
		/// </summary>
		public string Type;

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
		public Guid RequirementId;

		/// <summary>
		/// 资源费用
		/// </summary>
		public decimal Price;

		/// <summary>
		/// 费用类型： 差旅费、招待费、会议费、培养费
		/// </summary>
		public string PriceType;

		/// <summary>
		/// 日期
		/// </summary>
		public DateTime PriceDate;

		/// <summary>
		/// 事由
		/// </summary>
		public string PriceReason;

		public Resource(string type,int number,int hour, Guid requirementId, decimal price,string priceType, DateTime priceDate, string priceReason)
		{
			Type = type;
			Number = number;
			RequirementId = requirementId;
			Price = price;
			PriceType = priceType;
			PriceDate = priceDate;
			PriceReason = priceReason;
		}

		public void SetResourceNumberAndTime(int number,int hour)
		{
			Number = number;
			Hour = hour;
		}

		public void SetResourcePrice(decimal price)
		{
			Price = price;
		}
	}
}