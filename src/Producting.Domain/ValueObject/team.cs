using System;
using System.Collections.Generic;
using MSFramework.Domain;

namespace Producting.Domain.AggregateRoot
{
	public class Team : ValueObject
	{
		private readonly Guid _id;

		/// <summary>
		/// 团队名称
		/// </summary>
		private readonly string _name;


		private Team()
		{
		}

		public Team(Guid id, string name, int level)
		{
			_id = id;
			_name = name;
		}

		protected override IEnumerable<object> GetAtomicValues()
		{
			yield return _name;
			yield return _id;
		}
	}
}