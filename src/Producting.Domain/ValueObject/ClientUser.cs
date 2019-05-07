using System;
using System.Collections.Generic;
using MSFramework.Domain;

namespace Producting.Domain.AggregateRoot
{
	public class ClientUser : ValueObject
	{
		/// <summary>
		/// clientId
		/// </summary>
		private readonly Guid _clientId;

		/// <summary>
		/// clientName
		/// </summary>
		private readonly string _clientName;
		
		/// <summary>
		/// shortName
		/// </summary>
		private readonly string _shortName;

		/// <summary>
		/// id
		/// </summary>
		private readonly Guid _id;

		/// <summary>
		/// 姓名
		/// </summary>
		private readonly string _name;

		private ClientUser()
		{
		}

		public ClientUser(Guid clientId, string clientName,string shortName, Guid id, string name)
		{
			_id = id;
			_name = name;
			_shortName = shortName;
			_clientId = clientId;
			_clientName = clientName;
		}

		protected override IEnumerable<object> GetAtomicValues()
		{
			yield return _clientId;
			yield return _clientName;
			yield return _shortName;
			yield return _name;
			yield return _id;
		}
	}
}