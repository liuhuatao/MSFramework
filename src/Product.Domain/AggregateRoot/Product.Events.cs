using System;
using System.Collections.Generic;
using MSFramework.Domain.Event;

namespace Product.Domain.AggregateRoot
{
	/// <summary>
	/// 路演产品创建
	/// </summary>
	public class PushRoadShowProductCreatedEvent : AggregateEventBase
	{
		/// <summary>
		/// 产品名称
		/// </summary>
		public string Name { get; }

		/// <summary>
		/// 产品类型：数据报告、调研、电话、会议、路演
		/// </summary>
		public string Type { get; }

		/// <summary>
		/// 行业Id
		/// </summary>
		public Guid IndustryId { get; }

		/// <summary>
		/// 公司Id
		/// </summary>
		public Guid CompanyId { get; }

		/// <summary>
		/// 产品负责人Id
		/// </summary>
		public Guid OwnerId { get; }

		/// <summary>
		/// 产品团队Id
		/// </summary>
		public Guid TeamId { get; }

		/// <summary>
		/// 产品描述
		/// </summary>
		public string Description { get; }

		/// <summary>
		/// 是否发布客户
		/// </summary>
		public bool IsRelease { get; }

		/// <summary>
		/// 评估状态： 待评估、可执行、不可行
		/// </summary>
		public string EvaluationStatus { get; }

		/// <summary>
		/// 评估描述
		/// </summary>
		public string EvaluationDescription { get; }

		/// <summary>
		/// pushRoadShow
		/// </summary>
		public PushRoadShowProductionExtend PushRoadShowProductionExtend { get; }

		public PushRoadShowProductCreatedEvent(string name, string type, Guid industryId, Guid companyId, Guid ownerId,
			Guid teamId, string description, bool isRelease, string evaluationStatus, string evaluationDescription,
			PushRoadShowProductionExtend pushRoadShowProductionExtend
		)
		{
			Name = name;
			Type = type;
			IndustryId = industryId;
			CompanyId = companyId;
			OwnerId = ownerId;
			TeamId = teamId;
			Description = description;
			IsRelease = isRelease;
			EvaluationStatus = evaluationStatus;
			EvaluationDescription = evaluationDescription;
			PushRoadShowProductionExtend = pushRoadShowProductionExtend;
		}
	}

	/// <summary>
	/// 基础产品创建
	/// </summary>
	public class BasicProductCreatedEvent : AggregateEventBase
	{
		/// <summary>
		/// 产品名称
		/// </summary>
		public string Name { get; }

		/// <summary>
		/// 产品类型：数据报告、调研、电话、会议、路演
		/// </summary>
		public string Type { get; }

		/// <summary>
		/// 行业Id
		/// </summary>
		public Guid IndustryId { get; }

		/// <summary>
		/// 公司Id
		/// </summary>
		public Guid CompanyId { get; }

		/// <summary>
		/// 产品负责人Id
		/// </summary>
		public Guid OwnerId { get; }

		/// <summary>
		/// 产品团队Id
		/// </summary>
		public Guid TeamId { get; }

		/// <summary>
		/// 产品描述
		/// </summary>
		public string Description { get; }

		/// <summary>
		/// 是否发布客户
		/// </summary>
		public bool IsRelease { get; }

		/// <summary>
		/// 评估状态： 待评估、可执行、不可行
		/// </summary>
		public string EvaluationStatus { get; }

		/// <summary>
		/// 评估描述
		/// </summary>
		public string EvaluationDescription { get; }

		public BasicProductCreatedEvent(string name, string type, Guid industryId, Guid companyId, Guid ownerId,
			Guid teamId, string description, bool isRelease, string evaluationStatus, string evaluationDescription)
		{
			Name = name;
			Type = type;
			IndustryId = industryId;
			CompanyId = companyId;
			OwnerId = ownerId;
			TeamId = teamId;
			Description = description;
			IsRelease = isRelease;
			EvaluationStatus = evaluationStatus;
			EvaluationDescription = evaluationDescription;
		}
	}

	/// <summary>
	/// 数据产品创建
	/// </summary>
	public class DataProductCreatedEvent : AggregateEventBase
	{
		/// <summary>
		/// 产品名称
		/// </summary>
		public string Name { get; }

		/// <summary>
		/// 产品类型：数据报告、调研、电话、会议、路演
		/// </summary>
		public string Type { get; }

		/// <summary>
		/// 行业Id
		/// </summary>
		public Guid IndustryId { get; }

		/// <summary>
		/// 公司Id
		/// </summary>
		public Guid CompanyId { get; }

		/// <summary>
		/// 产品负责人Id
		/// </summary>
		public Guid OwnerId { get; }

		/// <summary>
		/// 产品团队Id
		/// </summary>
		public Guid TeamId { get; }

		/// <summary>
		/// 产品描述
		/// </summary>
		public string Description { get; }

		/// <summary>
		/// 是否发布客户
		/// </summary>
		public bool IsRelease { get; }

		/// <summary>
		/// 评估状态： 待评估、可执行、不可行
		/// </summary>
		public string EvaluationStatus { get; }

		/// <summary>
		/// 评估描述
		/// </summary>
		public string EvaluationDescription { get; }

		public DataProductionExtend DataProductionExtend { get; }

		public DataProductCreatedEvent(string name, string type, Guid industryId, Guid companyId, Guid ownerId,
			Guid teamId, string description, bool isRelease, string evaluationStatus, string evaluationDescription,
			DataProductionExtend dataProductionExtend
		)
		{
			Name = name;
			Type = type;
			IndustryId = industryId;
			CompanyId = companyId;
			OwnerId = ownerId;
			TeamId = teamId;
			Description = description;
			IsRelease = isRelease;
			EvaluationStatus = evaluationStatus;
			EvaluationDescription = evaluationDescription;
			DataProductionExtend = dataProductionExtend;
		}
	}

	public class ProductUsersChangeEvent : AggregateEventBase
	{
		/// <summary>
		/// 产品负责人Id
		/// </summary>
		public Guid OwnerId { get; }

		public ProductUsersChangeEvent(Guid ownerId)
		{
			OwnerId = ownerId;
		}
	}

	public class ProductEvaluationStatusChangeEvent : AggregateEventBase
	{
		/// <summary>
		/// 修改产品评估状态
		/// </summary>
		public string EvaluationStatus { get; }

		public ProductEvaluationStatusChangeEvent(string evaluationStatus)
		{
			EvaluationStatus = evaluationStatus;
		}
	}
	
	public class ProductResourceCreateEvent : AggregateEventBase
	{
		/// <summary>
		/// 修改产品评估状态
		/// </summary>
		public Resource Resource { get; }

		public ProductResourceCreateEvent(Resource resource)
		{
			Resource = resource;
		}
	}
	
	/// <summary>
	/// 发布产品
	/// </summary>
	public class ReleaseProductEvent : AggregateEventBase
	{
		/// <summary>
		/// 修改产品评估状态
		/// </summary>
		public bool IsRelease { get; }

		public ReleaseProductEvent()
		{
			IsRelease = true;
		}
	}
	
	/// <summary>
	/// 取消发布产品
	/// </summary>
	public class CancelReleaseProductEvent : AggregateEventBase
	{
		/// <summary>
		/// 修改产品评估状态
		/// </summary>
		public bool IsRelease { get; }

		public CancelReleaseProductEvent()
		{
			IsRelease = false;
		}
	}
}