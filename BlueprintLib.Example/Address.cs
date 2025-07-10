using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml.Serialization;
using BlueprintLib;
using BlueprintLib.Attributes;


namespace BlueprintLib.Example
{
    [ Blueprint( @"Model.Template*"), Blueprint("NotFound"), ]
	public partial class Address 
	{
		[XmlIgnore]
		public byte ShouldIgnore { get; set; }

		public byte AddressID { get; set; }

		public string Street { get; set; }
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
