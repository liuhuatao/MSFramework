using System;
using System.Collections.Generic;
using MSFramework.Domain;

namespace Product.Domain.AggregateRoot
{
	public class DataProductionExtend : ValueObject
	{
		/// <summary>
		/// 是否锁定
		/// </summary>
		public bool Locked;
		
		/// <summary>
		/// 要求锁定的客户Id
		/// </summary>
		public Guid LockedClientId;
		
		/// <summary>
		/// 周期：季度、月度、双周、周度
		/// </summary>
		public string Cycle;
		
		/// <summary>
		/// 调研指标
		/// </summary>
		public string ResearchTarget;

		/// <summary>
		/// 调研产品
		/// </summary>
		public string ResearchProduct;

		/// <summary>
		/// 呈现形式 ppt、excel
		/// </summary>
		public string ExpressionType;

		/// <summary>
		/// 历史数据时间长度
		/// </summary>
		public string HistoryDataTimeLength;

		/// <summary>
		/// 拟合系数
		/// </summary>
		public string FitCoefficient;

		/// <summary>
		/// 样本占比
		/// </summary>
		public string SampleRatio;

		/// <summary>
		/// 渠道匹配度
		/// </summary>
		public string ChannelMatch;

		/// <summary>
		/// 区域匹配度
		/// </summary>
		public string AreaMatch;

		private DataProductionExtend()
		{
		}

		public DataProductionExtend(bool locked,Guid lockedClientId,string cycle,string researchTarget,
			string researchProduct,string expressionType,string historyDataTimeLength,string fitCoefficient,
			string sampleRatio,string channelMatch,string areaMatch)
		{
			Locked = locked;
			LockedClientId = lockedClientId;
			Cycle = cycle;
			ResearchTarget = researchTarget;
			ResearchProduct = researchProduct;
			ExpressionType = expressionType;
			HistoryDataTimeLength = historyDataTimeLength;
			FitCoefficient = fitCoefficient;
			SampleRatio = sampleRatio;
			ChannelMatch = channelMatch;
			AreaMatch = areaMatch;
		} 

		protected override IEnumerable<object> GetAtomicValues()
		{
			yield return Locked;
			yield return LockedClientId;
			yield return Cycle;
			yield return ResearchTarget;
			yield return ResearchProduct;
			yield return ExpressionType;
			yield return HistoryDataTimeLength;
			yield return FitCoefficient;
			yield return SampleRatio;
			yield return ChannelMatch;
			yield return AreaMatch;
		}
	}
}