using System;
using System.Collections.Generic;
using MSFramework.Domain;

namespace Producting.Domain.AggregateRoot
{
	public class Industry : ValueObject
	{
		private readonly Guid _id;

		/// <summary>
		/// 行业名称
		/// </summary>
		private readonly string _name;

		/// <summary>
		/// 行业等级
		/// </summary>
		private readonly int _level;


		private Industry()
		{
		}

		public Industry(Guid id, string name, int level)
		{
			_id = id;
			_name = name;
			_level = level;
		}

		protected override IEnumerable<object> GetAtomicValues()
		{
			yield return _name;
			yield return _id;
			yield return _level;
		}
	}
}