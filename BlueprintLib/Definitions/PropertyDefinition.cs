using BlueprintLib.Definitions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace BlueprintLib
{
	public class PropertyDefinition : ObjectDefinition
	{

		public List<AttributeDefinition> Attributes
		{
			get;
			private set;
		}
		public string Name { get; private set; }
		public string TypeName { get; private set; }

		

		public PropertyDefinition(string Name,string TypeName) : base()
		{
			this.Attributes = new List<AttributeDefinition>();
			this.Name=Name;
			this.TypeName = TypeName;
		}
		public override string ToString()
		{
			return Name;
		}





	}
}
