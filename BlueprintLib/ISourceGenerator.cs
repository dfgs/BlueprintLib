using System;
using System.Collections.Generic;
using System.Text;

namespace BlueprintLib
{
	public interface ISourceGenerator<T>
	{
		string GenerateSource(T SchemaObject);
	}
}
