using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace BlueprintLib
{
	public class AttributeParameterDefinition : ObjectDefinition
	{

		public string Name { get; private set; }
		public string? Value { get; private set; }


		public AttributeParameterDefinition( string Name, string? Value) : base()
		{
			this.Name = Name;
			this.Value = Value;
		}
		public override string ToString()
		{
			return $"{Name}: {Value}";
		}





	}
}
