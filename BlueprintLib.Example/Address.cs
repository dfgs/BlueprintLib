using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml.Serialization;
using BlueprintLib;
using BlueprintLib.Attributes;

namespace BlueprintLib.Example
{
    [ClassBlueprint( @"TableModel.bp"), ClassBlueprint("test1.bp")]
	public partial class Address 
	{
		[XmlIgnore]
		public byte ShouldIgnore { get; set; }

		//[Column,PrimaryKey]
		public byte AddressID { get; set; }

		//[Column]
		public string Street { get; set; }
		//[Column]
		public byte? Number { get; set; }

		public Address(byte AddressID, string Street)
		{
			this.AddressID = AddressID; this.Street = Street;
		}
		public override string ToString()
		{
			return $"{Number} {Street}";
		} 


	}

}
