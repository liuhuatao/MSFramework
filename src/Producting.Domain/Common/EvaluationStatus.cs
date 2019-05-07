using MSFramework.Domain;

namespace Producting.Domain.AggregateRoot
{
	public class EvaluationStatus : Enumeration
	{
		
		/// <summary>
		/// 待评估
		/// </summary>
		public static EvaluationStatus NeedAssess = new EvaluationStatus(1, nameof(NeedAssess).ToLowerInvariant());
		
		/// <summary>
		/// 可执行
		/// </summary>
		public static EvaluationStatus Executable = new EvaluationStatus(2, nameof(Executable).ToLowerInvariant());
		
		/// <summary>
		/// 不可行
		/// </summary>
		public static EvaluationStatus NonExecutable = new EvaluationStatus(3, nameof(NonExecutable).ToLowerInvariant());
	
		public EvaluationStatus(int id, string name) : base(id, name)
		{
		}
	}
}