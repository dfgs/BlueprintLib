using System;
using System.Collections.Generic;
using System.Text;

namespace BlueprintLib
{
	public abstract class BaseSourceGenerator<T>: ISourceGenerator<T>
	{
		public abstract string GenerateSource(T SchemaObject);
	}
}
