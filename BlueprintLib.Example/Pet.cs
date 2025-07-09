using System;
using System.Collections.Generic;
using System.Text;
using BlueprintLib;
using System.Diagnostics.CodeAnalysis;
using BlueprintLib.Attributes;

namespace BlueprintLib.Example
{
	[Blueprint(@"Model.Template1")]
	public class Pet
	{
		public byte PetID { get; set; }

		public string Name { get; set; }
		
		public Pet(byte PetID, string Name)
		{
			this.PetID = PetID;this.Name = Name;
		}
		public override string ToString()
		{
			return $"{Name}";
		}


	}
}
