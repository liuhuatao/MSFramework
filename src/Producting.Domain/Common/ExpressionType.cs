using MSFramework.Domain;

namespace Producting.Domain.AggregateRoot
{
	/// <summary>
	/// 呈现形式
	/// </summary>
	public class ExpressionType : Enumeration
	{
		/// <summary>
		/// ppt
		/// </summary>
		public static ExpressionType Ppt = new ExpressionType(1, nameof(Ppt).ToLowerInvariant());

		/// <summary>
		/// excel
		/// </summary>
		public static ExpressionType Excel = new ExpressionType(2, nameof(Excel).ToLowerInvariant());
		
		/// <summary>
		/// ppt and excel
		/// </summary>
		public static ExpressionType PptAndExcel = new ExpressionType(3, nameof(PptAndExcel).ToLowerInvariant());
	

		public ExpressionType(int id, string name) : base(id, name)
		{
		}
	}
}