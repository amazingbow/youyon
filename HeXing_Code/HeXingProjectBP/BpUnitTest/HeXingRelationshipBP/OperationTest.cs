﻿

namespace UFIDA.U9.Cust.HeXingProjectBP.HeXingRelationshipBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.IO;
	using NUnit.Framework;
	
	/// <summary>
	/// Business operation test
	/// </summary> 
	[TestFixture]		
	public class OperationTest
	{
		private Proxy.OperationProxy obj = new Proxy.OperationProxy();

		public OperationTest()
		{
		}
		#region AutoTestCode ...
		[Test]
		public void TestDo()
		{
			obj.Do() ;  
		
		}
		#endregion 				
	}
	
}