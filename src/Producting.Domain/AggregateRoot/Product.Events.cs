using System;
using System.Collections.Generic;
using MSFramework.Domain.Event;

namespace Producting.Domain.AggregateRoot
{
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
		public ProductType Type { get; }

		/// <summary>
		/// 行业1
		/// </summary>
		public Industry Industry1 { get; }

		/// <summary>
		/// 行业2
		/// </summary>
		public Industry Industry2 { get; }

		/// <summary>
		/// 行业3
		/// </summary>
		public Industry Industry3 { get; }


		/// <summary>
		/// 公司Id
		/// </summary>
		public Company Company { get; }

		/// <summary>
		/// 产品负责人Id
		/// </summary>
		public User Owner { get; }

		/// <summary>
		/// 参与人
		/// </summary>
		public List<User> Users { get; }

		/// <summary>
		/// 产品团队Id
		/// </summary>
		public Team Team { get; }

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
		public EvaluationStatus EvaluationStatus { get; }

		/// <summary>
		/// 评估描述
		/// </summary>
		public string EvaluationDescription { get; }

		public BasicProductCreatedEvent(string name, ProductType type, Industry industry1, Industry industry2,
			Industry industry3, Company company, User owner, List<User> users, Team team, string description,
			bool isRelease,
			EvaluationStatus evaluationStatus, string evaluationDescription)
		{
			Name = name;
			Type = type;
			Industry1 = industry1;
			Industry2 = industry2;
			Industry3 = industry3;
			Company = company;
			Owner = owner;
			Users = users;
			Team = team;
			Description = description;
			IsRelease = isRelease;
			EvaluationStatus = evaluationStatus;
			EvaluationDescription = evaluationDescription;
		}
	}
	
	/// <summary>
	/// 基础产品修改
	/// </summary>
	public class BasicProductUpdateEvent : AggregateEventBase
	{
		/// <summary>
		/// 产品名称
		/// </summary>
		public string Name { get; }

		/// <summary>
		/// 产品类型：数据报告、调研、电话、会议、路演
		/// </summary>
		public ProductType Type { get; }

		/// <summary>
		/// 行业1
		/// </summary>
		public Industry Industry1 { get; }

		/// <summary>
		/// 行业2
		/// </summary>
		public Industry Industry2 { get; }

		/// <summary>
		/// 行业3
		/// </summary>
		public Industry Industry3 { get; }


		/// <summary>
		/// 公司Id
		/// </summary>
		public Company Company { get; }

		/// <summary>
		/// 产品负责人Id
		/// </summary>
		public User Owner { get; }

		/// <summary>
		/// 参与人
		/// </summary>
		public List<User> Users { get; }

		/// <summary>
		/// 产品团队Id
		/// </summary>
		public Team Team { get; }

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
		public EvaluationStatus EvaluationStatus { get; }

		/// <summary>
		/// 评估描述
		/// </summary>
		public string EvaluationDescription { get; }

		public BasicProductUpdateEvent(string name, ProductType type, Industry industry1, Industry industry2,
			Industry industry3, Company company, User owner, List<User> users, Team team, string description,
			bool isRelease,
			EvaluationStatus evaluationStatus, string evaluationDescription)
		{
			Name = name;
			Type = type;
			Industry1 = industry1;
			Industry2 = industry2;
			Industry3 = industry3;
			Company = company;
			Owner = owner;
			Users = users;
			Team = team;
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
		public ProductType Type { get; }

		/// <summary>
		/// 行业1
		/// </summary>
		public Industry Industry1 { get; }

		/// <summary>
		/// 行业2
		/// </summary>
		public Industry Industry2 { get; }

		/// <summary>
		/// 行业3
		/// </summary>
		public Industry Industry3 { get; }

		/// <summary>
		/// 公司Id
		/// </summary>
		public Company Company { get; }

		/// <summary>
		/// 产品负责人Id
		/// </summary>
		public User Owner { get; }

		/// <summary>
		/// 参与人
		/// </summary>
		public List<User> Users { get; }

		/// <summary>
		/// 产品团队Id
		/// </summary>
		public Team Team { get; }

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
		public EvaluationStatus EvaluationStatus { get; }

		/// <summary>
		/// 评估描述
		/// </summary>
		public string EvaluationDescription { get; }

		public DataProductionExtend DataProductionExtend { get; }

		public DataProductCreatedEvent(string name, ProductType type, Industry industry1, Industry industry2,
			Industry industry3, Company company, User owner, List<User> users, Team team, string description,
			bool isRelease,
			EvaluationStatus evaluationStatus, string evaluationDescription, DataProductionExtend dataProductionExtend
		)
		{
			Name = name;
			Type = type;
			Industry1 = industry1;
			Industry2 = industry2;
			Industry3 = industry3;
			Company = company;
			Owner = owner;
			Users = users;
			Team = team;
			Description = description;
			IsRelease = isRelease;
			EvaluationStatus = evaluationStatus;
			EvaluationDescription = evaluationDescription;
			DataProductionExtend = dataProductionExtend;
		}
	}
	
	/// <summary>
	/// 数据产品修改
	/// </summary>
	public class DataProductUpdateEvent : AggregateEventBase
	{
		/// <summary>
		/// 产品名称
		/// </summary>
		public string Name { get; }

		/// <summary>
		/// 产品类型：数据报告、调研、电话、会议、路演
		/// </summary>
		public ProductType Type { get; }

		/// <summary>
		/// 行业1
		/// </summary>
		public Industry Industry1 { get; }

		/// <summary>
		/// 行业2
		/// </summary>
		public Industry Industry2 { get; }

		/// <summary>
		/// 行业3
		/// </summary>
		public Industry Industry3 { get; }

		/// <summary>
		/// 公司Id
		/// </summary>
		public Company Company { get; }

		/// <summary>
		/// 产品负责人Id
		/// </summary>
		public User Owner { get; }

		/// <summary>
		/// 参与人
		/// </summary>
		public List<User> Users { get; }

		/// <summary>
		/// 产品团队Id
		/// </summary>
		public Team Team { get; }

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
		public EvaluationStatus EvaluationStatus { get; }

		/// <summary>
		/// 评估描述
		/// </summary>
		public string EvaluationDescription { get; }

		public DataProductionExtend DataProductionExtend { get; }

		public DataProductUpdateEvent(string name, ProductType type, Industry industry1, Industry industry2,
			Industry industry3, Company company, User owner, List<User> users, Team team, string description,
			bool isRelease,
			EvaluationStatus evaluationStatus, string evaluationDescription, DataProductionExtend dataProductionExtend
		)
		{
			Name = name;
			Type = type;
			Industry1 = industry1;
			Industry2 = industry2;
			Industry3 = industry3;
			Company = company;
			Owner = owner;
			Users = users;
			Team = team;
			Description = description;
			IsRelease = isRelease;
			EvaluationStatus = evaluationStatus;
			EvaluationDescription = evaluationDescription;
			DataProductionExtend = dataProductionExtend;
		}
	}

	/// <summary>
	/// 修改产品参与人
	/// </summary>
	public class ProductUsersChangeEvent : AggregateEventBase
	{
		/// <summary>
		/// 参与人
		/// </summary>
		public List<User> Users { get; }

		public ProductUsersChangeEvent(List<User> users)
		{
			Users = users;
		}
	}

	/// <summary>
	/// 修改产品评估状态
	/// </summary>
	public class ProductEvaluationStatusChangeEvent : AggregateEventBase
	{
		/// <summary>
		/// 修改产品评估状态
		/// </summary>
		public DataProductionExtend DataProductionExtend { get; }

		public ProductEvaluationStatusChangeEvent(DataProductionExtend dataProductionExtend)
		{
			DataProductionExtend = dataProductionExtend;
		}
	}

	/// <summary>
	/// 创建资源
	/// </summary>
	public class ProductResourceCreateEvent : AggregateEventBase
	{
		/// <summary>
		/// 创建资源
		/// </summary>
		public Resource Resource { get; }

		public ProductResourceCreateEvent(Resource resource)
		{
			Resource = resource;
		}
	}
	
	/// <summary>
	/// 修改资源
	/// </summary>
	public class ProductResourceUpdateEvent : AggregateEventBase
	{
		/// <summary>
		/// 创建资源
		/// </summary>
		public Resource Resource { get; }

		public ProductResourceUpdateEvent(Resource resource)
		{
			Resource = resource;
		}
	}
	
	/// <summary>
	/// 修改产品资源价格
	/// </summary>
	public class ProductResourceUpdatePriceEvent : AggregateEventBase
	{
		public Resource Resource { get; }

		public ProductResourceUpdatePriceEvent(Resource resource)
		{
			Resource = resource;
		}
	}
	
	/// <summary>
	/// 新增资源需求
	/// </summary>
	public class ProductResourceAddRequirementEvent : AggregateEventBase
	{
		public Resource Resource { get; }

		public ProductResourceAddRequirementEvent(Resource resource)
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