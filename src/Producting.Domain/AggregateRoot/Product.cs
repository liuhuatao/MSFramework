using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using MSFramework.Domain;

namespace Producting.Domain.AggregateRoot
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
		private ProductType _type;

		/// <summary>
		/// 行业1
		/// </summary>
		private Industry _industry1;

		/// <summary>
		/// 行业2
		/// </summary>
		private Industry _industry2;

		/// <summary>
		/// 行业3
		/// </summary>
		private Industry _industry3;

		/// <summary>
		/// 公司 标的
		/// </summary>
		private Company _company;

		/// <summary>
		/// 产品负责人Id
		/// </summary>
		private User _owner;

		/// <summary>
		/// 参与人
		/// </summary>
		private List<User> _users;

		/// <summary>
		/// 产品团队
		/// </summary>
		private Team _team;

		/// <summary>
		/// 产品描述
		/// </summary>
		private string _description;


		/// <summary>
		/// 是否发布客户
		/// </summary>
		private bool _isRelease;
		
		/// <summary>
		/// 数据产品拓展
		/// </summary>
		private DataProductionExtend _dataProductionExtend;


		private Resource _resource;

		private Product()
		{
		}

		public Product(string name, ProductType type, Industry industry1, Industry industry2, Industry industry3,
			Company company, User owner,List<User> users, Team team, string description, bool isRelease, EvaluationStatus evaluationStatus,
			string evaluationDescription)
		{
			ApplyAggregateEvent(new BasicProductCreatedEvent(name, type, industry1, industry2, industry3,
				company, owner,users, team,
				description, isRelease, evaluationStatus, evaluationDescription));
		}


		/// <summary>
		/// 创建产品
		/// </summary>
		/// <param name="e"></param>
		private void Apply(BasicProductCreatedEvent e)
		{
			Version = e.Version;

			_name = e.Name;
			_type = e.Type;
			_industry1 = e.Industry1;
			_industry2 = e.Industry2;
			_industry3 = e.Industry3;
			_company = e.Company;
			_owner = e.Owner;
			_users = e.Users;
			_team = e.Team;
			_description = e.Description;
		}
		
		/// <summary>
		/// 创建产品
		/// </summary>
		/// <param name="e"></param>
		private void Apply(BasicProductUpdateEvent e)
		{
			Version = e.Version;

			_name = e.Name;
			_type = e.Type;
			_industry1 = e.Industry1;
			_industry2 = e.Industry2;
			_industry3 = e.Industry3;
			_company = e.Company;
			_owner = e.Owner;
			_users = e.Users;
			_team = e.Team;
			_description = e.Description;
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
			_industry1 = e.Industry1;
			_industry2 = e.Industry2;
			_industry3 = e.Industry3;
			_company = e.Company;
			_owner = e.Owner;
			_users = e.Users;
			_team = e.Team;
			_description = e.Description;
			_dataProductionExtend= e.DataProductionExtend;
		}
	    
		/// <summary>
		/// 修改数据产品
		/// </summary>
		/// <param name="e"></param>
		private void Apply(DataProductUpdateEvent e)
		{
			Version = e.Version;

			_name = e.Name;
			_type = e.Type;
			_industry1 = e.Industry1;
			_industry2 = e.Industry2;
			_industry3 = e.Industry3;
			_company = e.Company;
			_owner = e.Owner;
			_users = e.Users;
			_team = e.Team;
			_description = e.Description;
			_dataProductionExtend= e.DataProductionExtend;
		}

		/// <summary>
		/// 修改产品参与人
		/// </summary>
		/// <param name="e"></param>
		private void Apply(ProductUsersChangeEvent e)
		{
			Version = e.Version;
			
			_users = e.Users;
		}

		/// <summary>
		/// 修改评估状态
		/// </summary>
		/// <param name="e"></param>
		private void Apply(ProductEvaluationStatusChangeEvent e)
		{
			Version = e.Version;

			_dataProductionExtend = e.DataProductionExtend;
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
		/// 修改产品资源
		/// </summary>
		/// <param name="e"></param>
		private void Apply(ProductResourceUpdateEvent e)
		{
			Version = e.Version;

			_resource = e.Resource;
		}

		/// <summary>
		/// 修改产品资源价格
		/// </summary>
		/// <param name="e"></param>
		//Todo 待完善
		private void Apply(ProductResourceUpdatePriceEvent e)
		{
			Version = e.Version;

			_resource = e.Resource;
		}
		
		/// <summary>
		/// 提交需求
		/// </summary>
		/// <param name="e"></param>
		//Todo 待完善
		private void Apply(ProductResourceAddRequirementEvent e)
		{
			Version = e.Version;

			_resource = e.Resource;
		}
		
		//Todo 导出产品列表 PDF（这个看看能不能二期做）

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