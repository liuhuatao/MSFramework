using System;
using System.Collections.Generic;
using MSFramework.Domain;

namespace Producting.Domain.AggregateRoot
{
	public class Company : ValueObject
	{
		private readonly Guid _id;

		/// <summary>
		/// 公司名
		/// </summary>
		private readonly string _name;

		/// <summary>
		/// 描述
		/// </summary>
		private readonly string _description;

		/// <summary>
		/// 类型, A股 H股 非上市公司
		/// </summary>
		private readonly string _type;


		private Company()
		{
		}

		public Company(Guid id, string name, string description, string type)
		{
			_id = id;
			_name = name;
			_description = description;
			_type = type;
		}

		protected override IEnumerable<object> GetAtomicValues()
		{
			yield return _id;
			yield return _name;
			yield return _description;
			yield return _type;
		}
	}
}