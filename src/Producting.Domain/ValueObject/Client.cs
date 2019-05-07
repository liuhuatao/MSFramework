using System;
using System.Collections.Generic;
using MSFramework.Domain;

namespace Producting.Domain.AggregateRoot
{
	public class Client : ValueObject
	{
		private readonly Guid _id;

		/// <summary>
		/// 姓名
		/// </summary>
		private readonly string _name;

		private Client()
		{
		}

		public Client(Guid id, string name)
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