using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Xml.Linq;

namespace BlueprintLib
{
	public static class AttributeSyntaxHelpers
	{


		public static T? GetTypeSymbol<T>(this SyntaxNode Node, SemanticModel SemanticModel)
			where T : class
		{
			return SemanticModel.GetDeclaredSymbol(Node) as T;
		}
		

		public static T? GetTypeSymbol<T>(this SyntaxNode Node, Compilation Compilation)
			where T :class
		{
			SemanticModel semanticModel = Compilation.GetSemanticModel(Node.SyntaxTree);
			return Node.GetTypeSymbol<T>(semanticModel);
		}

	}
}
