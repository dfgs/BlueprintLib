using System;
using System.Collections.Generic;
using System.Text;

namespace BlueprintLib.Definitions
{
	public interface IAttributeContainer
	{
		IEnumerable<AttributeDefinition> Attributes { get; }
	}
}
