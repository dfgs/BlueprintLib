using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace BlueprintLib
{
	public class ClassDefinition : ObjectDefinition
	{

		public List<AttributeDefinition> Attributes
		{
			get;
			private set;
		}
		public string Namespace { get; private set; }
		public string Name { get; private set; }


		
		public ClassDefinition(string Namespace,  string Name) : base()
		{
			this.Attributes = new List<AttributeDefinition>();
			this.Namespace = Namespace; this.Name = Name;
		}
		public override string ToString()
		{
			return Name;
		}





	}
}
