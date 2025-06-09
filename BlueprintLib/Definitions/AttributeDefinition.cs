using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace BlueprintLib
{
	public class AttributeDefinition : ObjectDefinition
	{
		public List<AttributeParameterDefinition> Parameters
		{
			get;
			private set;
		}
		public string Name { get; private set; }

		
		public AttributeDefinition( string Name) : base()
		{
			this.Parameters = new List<AttributeParameterDefinition>();
			this.Name = Name;
		}
		public override string ToString()
		{
			return Name;
		}





	}
}
