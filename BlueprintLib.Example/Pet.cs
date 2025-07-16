using System;
using System.Collections.Generic;
using System.Text;
using BlueprintLib;
using System.Diagnostics.CodeAnalysis;
using BlueprintLib.Attributes;

namespace BlueprintLib.Example
{
	[DTO("Pet"), Blueprint(@"Model.Template1"), Blueprint(@"DTO"),]
	public partial class Pet
	{
	

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
