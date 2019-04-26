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
		public bool Locked { get; private set; }

		/// <summary>
		/// 要求锁定的客户Id
		/// </summary>
		public Guid LockedClientId { get; private set; }

		/// <summary>
		/// 周期：季度、月度、双周、周度
		/// </summary>
		public string Cycle { get; private set; }

		/// <summary>
		/// 调研指标
		/// </summary>
		public string ResearchTarget { get; private set; }

		/// <summary>
		/// 调研产品
		/// </summary>
		public string ResearchProduct { get; private set; }

		/// <summary>
		/// 呈现形式 ppt、excel
		/// </summary>
		public string ExpressionType { get; private set; }

		/// <summary>
		/// 历史数据时间长度
		/// </summary>
		public string HistoryDataTimeLength { get; private set; }

		/// <summary>
		/// 拟合系数
		/// </summary>
		public string FitCoefficient { get; private set; }

		/// <summary>
		/// 样本占比
		/// </summary>
		public string SampleRatio { get; private set; }

		/// <summary>
		/// 渠道匹配度
		/// </summary>
		public string ChannelMatch { get; private set; }

		/// <summary>
		/// 区域匹配度
		/// </summary>
		public string AreaMatch { get; private set; }

		private DataProductionExtend()
		{
		}

		public DataProductionExtend(bool locked, Guid lockedClientId, string cycle, string researchTarget,
			string researchProduct, string expressionType, string historyDataTimeLength, string fitCoefficient,
			string sampleRatio, string channelMatch, string areaMatch)
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