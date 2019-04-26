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
		private string _type;

		/// <summary>
		/// 数量
		/// </summary>
		private int _number;

		/// <summary>
		/// 工时
		/// </summary>
		private int _hour;

		/// <summary>
		/// 需求Id
		/// </summary>
		private Guid _requirementId;

		/// <summary>
		/// 资源费用
		/// </summary>
		private decimal _price;

		/// <summary>
		/// 费用类型： 差旅费、招待费、会议费、培养费
		/// </summary>
		private string _priceType;

		/// <summary>
		/// 日期
		/// </summary>
		private DateTime _priceDate;

		/// <summary>
		/// 事由
		/// </summary>
		private string _priceReason;
		
		public void SetResourceNumberAndTime(int number,int hour)
		{
			_number = number;
			_hour = hour;
		}

		public void SetResourcePrice(decimal price)
		{
			_price = price;
		}
	}
}