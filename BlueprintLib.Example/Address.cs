using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml.Serialization;
using BlueprintLib;
using BlueprintLib.Attributes;


namespace BlueprintLib.Example
{
	[DTO("Address"), Blueprint( @"Model.Template*"), Blueprint("NotFound"), Blueprint(@"DTO"),]
	public partial class Address 
	{
		


	}

}
