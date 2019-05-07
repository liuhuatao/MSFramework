using MSFramework.Domain;

namespace Producting.Domain.AggregateRoot
{
	/// <summary>
	/// 周期：季度、月度、双周、周度
	/// </summary>
	public class CycleType : Enumeration
	{
		/// <summary>
		/// 周度
		/// </summary>
		public static CycleType Weekly = new CycleType(1, nameof(Weekly).ToLowerInvariant());

		/// <summary>
		/// 双周
		/// </summary>
		public static CycleType DoubleWeekly = new CycleType(2, nameof(DoubleWeekly).ToLowerInvariant());
		
		/// <summary>
		/// 月度
		/// </summary>
		public static CycleType Monthly = new CycleType(3, nameof(Monthly).ToLowerInvariant());
			
		/// <summary>
		/// 季度
		/// </summary>
		public static CycleType Quarterly = new CycleType(4, nameof(Quarterly).ToLowerInvariant());


		public CycleType(int id, string name) : base(id, name)
		{
		}
	}
}