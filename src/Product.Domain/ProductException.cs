using System;

namespace Product.Domain
{
	public class ProductException : Exception
	{
		public ProductException(string msg) : base(msg)
		{
		}

		public ProductException(string msg, Exception e) : base(msg, e)
		{
		}
	}
}