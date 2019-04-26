using System;
using System.Collections.Generic;
using MSFramework.Domain;

namespace Product.Domain.AggregateRoot
{
	public class PushRoadShowProductionExtend : ValueObject
	{
		/// <summary>
		/// 路演核心观点
		/// </summary>
		public string Point{ get; private set; }

		private PushRoadShowProductionExtend()
		{
		}

		public PushRoadShowProductionExtend(string point)
		{
			Point = point;
		} 

		protected override IEnumerable<object> GetAtomicValues()
		{
			yield return Point;
		}
	}
}