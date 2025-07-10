using System;
using System.Collections.Generic;
using System.Text;
using BlueprintLib;
using System.Diagnostics.CodeAnalysis;
using BlueprintLib.Attributes;

namespace BlueprintLib.Example
{
    [Blueprint(@"Model.Template1")]
	public class Personn
	{
		public byte PersonnID { get; set; }

		public string FirstName { get; set; }
		
		public string LastName { get; set; }
		
		public byte Age { get; set; }

		public byte DeliveryAddressID { get; set; }

		public byte? BillingAddressID { get; set; }

		public byte PetID { get; set; }


		public Personn(byte PersonnID, string FirstName, string LastName, byte Age)
		{
			this.PersonnID = PersonnID; this.FirstName = FirstName;	this.LastName = LastName;this.Age = Age;
		}

		public override string ToString()
		{
			return $"{FirstName} {LastName}";
		}
	}
}
