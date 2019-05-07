using System;
using System.Collections.Generic;
using MSFramework.Domain;

namespace Producting.Domain.AggregateRoot
{
	public class Requirement : ValueObject
	{
		private readonly Guid _id;

		/// <summary>
		/// 需求详情
		/// </summary>
		private readonly string _detail;

		private Requirement()
		{
		}

		public Requirement(Guid id, string detail)
		{
			_id = id;
			_detail = detail;
		}

		protected override IEnumerable<object> GetAtomicValues()
		{
			yield return _id;
			yield return _detail;
		}
	}
}