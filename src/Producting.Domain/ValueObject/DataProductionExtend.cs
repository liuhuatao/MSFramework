using System;
using System.Collections.Generic;
using MSFramework.Domain;

namespace Producting.Domain.AggregateRoot
{
	public class DataProductionExtend : ValueObject
	{
		/// <summary>
		/// 一级产品名称
		/// </summary>
		public string OneLevelProductName { get; private set; }

		/// <summary>
		/// 评估状态： 待评估、可执行、不可行
		/// </summary>
		public EvaluationStatus EvaluationStatus { get;private set; }

		/// <summary>
		/// 评估描述
		/// </summary>
		public string EvaluationDescription { get; private set; }

		/// <summary>
		/// 是否锁定
		/// </summary>
		public bool Locked { get; private set; }

		/// <summary>
		/// 要求锁定的客户Id
		/// </summary>
		public Client LockedClient { get; private set; }

		/// <summary>
		/// 周期：季度、月度、双周、周度
		/// </summary>
		public CycleType Cycle { get; private set; }

		public DateTime OutPutTime { get; private set; }

		/// <summary>
		/// 调研指标
		/// </summary>
		public string ResearchTarget { get; private set; }

		/// <summary>
		/// 调研产品
		/// </summary>
		public string ResearchProduct { get; private set; }


		/// <summary>
		/// 调研对象
		/// </summary>
		public string ResearchObject { get; private set; }

		/// <summary>
		/// 核心观点
		/// </summary>
		public string Point { get; private set; }

		/// <summary>
		/// 呈现形式 ppt、excel、ppt And excel可多选
		/// </summary>
		public ExpressionType ExpressionType { get; private set; }

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
		
		/// <summary>
		/// 订阅客户联系人
		/// </summary>
		public List<ClientUser> ClientUsers { get; private set; }

		private DataProductionExtend()
		{
		}

		public DataProductionExtend(
			string oneLevelProductName, EvaluationStatus evaluationStatus,
			string evaluationDescription,
			bool locked, Client lockedClient, CycleType cycle, DateTime outPutTime, string researchTarget,
			string researchProduct, string researchObject, string point, ExpressionType expressionType,
			string historyDataTimeLength, string fitCoefficient,
			string sampleRatio, string channelMatch, string areaMatch,List<ClientUser> clientUsers)
		{
			OneLevelProductName = oneLevelProductName;
			EvaluationStatus = evaluationStatus;
			EvaluationDescription = evaluationDescription;
			Locked = locked;
			LockedClient = lockedClient;
			Cycle = cycle;
			OutPutTime = outPutTime;
			ResearchTarget = researchTarget;
			ResearchProduct = researchProduct;
			ResearchObject = researchObject;
			Point = point;
			ExpressionType = expressionType;
			HistoryDataTimeLength = historyDataTimeLength;
			FitCoefficient = fitCoefficient;
			SampleRatio = sampleRatio;
			ChannelMatch = channelMatch;
			AreaMatch = areaMatch;
			ClientUsers = clientUsers;
		}

		protected override IEnumerable<object> GetAtomicValues()
		{
			yield return OneLevelProductName;
			yield return EvaluationStatus;
			yield return EvaluationDescription;
			yield return Locked;
			yield return LockedClient;
			yield return Cycle;
			yield return OutPutTime;
			yield return ResearchTarget;
			yield return ResearchProduct;
			yield return ResearchObject;
			yield return Point;
			yield return ExpressionType;
			yield return HistoryDataTimeLength;
			yield return FitCoefficient;
			yield return SampleRatio;
			yield return ChannelMatch;
			yield return AreaMatch;
			yield return ClientUsers;
		}
	}
}