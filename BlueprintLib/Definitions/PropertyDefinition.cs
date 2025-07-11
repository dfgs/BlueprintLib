﻿using BlueprintLib.Definitions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Xml.Serialization;

namespace BlueprintLib
{
	[Serializable]
	public class PropertyDefinition : ObjectDefinition
	{

		public List<AttributeDefinition> Attributes
		{
			get;
			set;
		}
		[XmlAttribute]
		public string Name { get;  set; }
		[XmlAttribute]
		public string TypeName { get;  set; }


		public PropertyDefinition() : base()
		{
			this.Attributes = new List<AttributeDefinition>();
			this.Name = "Undefined";
			this.TypeName = "Undefined";
		}
		public PropertyDefinition(string Name,string TypeName) : base()
		{
			this.Attributes = new List<AttributeDefinition>();
			this.Name=Name;
			this.TypeName = TypeName;
		}
		public override string ToString()
		{
			return $$"""[{{string.Join(",", Attributes)}}] {{Name}}""";
		}





	}
}
