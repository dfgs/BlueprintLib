using System;
using System.Collections.Generic;
using System.Text;
using BlueprintLib;
using System.Diagnostics.CodeAnalysis;
using BlueprintLib.Attributes;

namespace BlueprintLib.Example
{
    [DTO("Personn"), Blueprint(@"Model.Template1"), Blueprint(@"DTO"),]
	public partial class Personn
	{
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
