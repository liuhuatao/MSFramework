using System;
using System.Runtime.InteropServices.ComTypes;
using MSFramework.Domain;

namespace Product.Domain.AggregateRoot
{
	public class Product : AggregateRootBase
	{
		/// <summary>
		/// 产品名称
		/// </summary>
		private string _name;

		/// <summary>
		/// 产品类型：数据报告、调研、电话、会议、路演
		/// </summary>
		private string _type;

		/// <summary>
		/// 行业Id
		/// </summary>
		private Guid _industryId;

		/// <summary>
		/// 公司Id
		/// </summary>
		private Guid _companyId;

		/// <summary>
		/// 产品负责人Id
		/// </summary>
		private Guid _ownerId;

		/// <summary>
		/// 产品团队Id
		/// </summary>
		private Guid _teamId;

		/// <summary>
		/// 产品描述
		/// </summary>
		private string _description;

		/// <summary>
		/// 是否发布客户
		/// </summary>
		private bool _isRelease;

		/// <summary>
		/// 评估状态： 待评估、可执行、不可行
		/// </summary>
		private string _evaluationStatus;

		/// <summary>
		/// 评估描述
		/// </summary>
		private string _evaluationDescription;

		private DataProductionExtend _dataProductionExtend;

		private PushRoadShowProductionExtend _pushRoadShowProductionExtend;

		private Resource _resource;

		private Product()
		{
		}

		public Product(string name, string type, Guid industryId, Guid companyId, Guid ownerId, Guid teamId,
			string description, bool isRelease, string evaluationStatus, string evaluationDescription)
		{
			if (string.IsNullOrEmpty(name))
			{
				throw new ProductException("产品名称不能为空！");
			}

			if (string.IsNullOrEmpty(type))
			{
				throw new ProductException("产品类型不能为空！");
			}

			ApplyAggregateEvent(new BasicProductCreatedEvent(name, type, industryId, companyId, ownerId, teamId,
				description, isRelease, evaluationStatus, evaluationDescription));
		}

		/// <summary>
		/// 创建路演产品
		/// </summary>
		/// <param name="e"></param>
		private void Apply(PushRoadShowProductCreatedEvent e)
		{
			Version = e.Version;

			_name = e.Name;
			_type = e.Type;
			_industryId = e.IndustryId;
			_companyId = e.CompanyId;
			_ownerId = e.OwnerId;
			_teamId = e.TeamId;
			_description = e.Description;
			_isRelease = e.IsRelease;
			_evaluationStatus = e.EvaluationStatus;
			_evaluationDescription = e.EvaluationDescription;
			_pushRoadShowProductionExtend = e.PushRoadShowProductionExtend;
		}

		/// <summary>
		/// 创建基础产品
		/// </summary>
		/// <param name="e"></param>
		private void Apply(BasicProductCreatedEvent e)
		{
			Version = e.Version;

			_name = e.Name;
			_type = e.Type;
			_industryId = e.IndustryId;
			_companyId = e.CompanyId;
			_ownerId = e.OwnerId;
			_teamId = e.TeamId;
			_description = e.Description;
			_isRelease = e.IsRelease;
			_evaluationStatus = e.EvaluationStatus;
			_evaluationDescription = e.EvaluationDescription;
		}

		/// <summary>
		/// 创建数据产品
		/// </summary>
		/// <param name="e"></param>
		private void Apply(DataProductCreatedEvent e)
		{
			Version = e.Version;

			_name = e.Name;
			_type = e.Type;
			_industryId = e.IndustryId;
			_companyId = e.CompanyId;
			_ownerId = e.OwnerId;
			_teamId = e.TeamId;
			_description = e.Description;
			_isRelease = e.IsRelease;
			_evaluationStatus = e.EvaluationStatus;
			_evaluationDescription = e.EvaluationDescription;
			_dataProductionExtend = e.DataProductionExtend;
		}

		/// <summary>
		/// 修改产品参与人
		/// </summary>
		/// <param name="e"></param>
		private void Apply(ProductUsersChangeEvent e)
		{
			Version = e.Version;

			_ownerId = e.OwnerId;
		}

		/// <summary>
		/// 修改评估状态
		/// </summary>
		/// <param name="e"></param>
		private void Apply(ProductEvaluationStatusChangeEvent e)
		{
			Version = e.Version;

			_evaluationStatus = e.EvaluationStatus;
		}

		/// <summary>
		/// 添加产品资源
		/// </summary>
		/// <param name="e"></param>
		private void Apply(ProductResourceCreateEvent e)
		{
			Version = e.Version;

			_resource = e.Resource;
		}

		/// <summary>
		/// 发布产品
		/// </summary>
		/// <param name="e"></param>
		private void Apply(ReleaseProductEvent e)
		{
			Version = e.Version;

			_isRelease = e.IsRelease;
		}

		/// <summary>
		/// 取消发布产品
		/// </summary>
		/// <param name="e"></param>
		private void Apply(CancelReleaseProductEvent e)
		{
			Version = e.Version;

			_isRelease = e.IsRelease;
		}
	}
}