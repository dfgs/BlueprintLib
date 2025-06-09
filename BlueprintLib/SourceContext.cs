using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace BlueprintLib
{
	internal class SourceContext
	{
		public Compilation Compilation
		{
			get;
			set;

		}
		public ImmutableArray<TypeDeclarationSyntax> TypeDeclarations
		{
			get;
			set;
		}
		
		public ImmutableArray<Blueprint> Blueprints
		{
			get;
			set;
		}
		public SourceContext(Compilation Compilation)
		{
			this.Compilation = Compilation;
			Blueprints=new ImmutableArray<Blueprint> { };
			TypeDeclarations = new ImmutableArray<TypeDeclarationSyntax>();
		}
		public SourceContext(Compilation Compilation, ImmutableArray<TypeDeclarationSyntax> TypeDeclarations)
		{
			this.Compilation = Compilation;
			this.TypeDeclarations = TypeDeclarations;
			this.Blueprints = new ImmutableArray<Blueprint> { };
		}
		public SourceContext(Compilation Compilation, ImmutableArray<TypeDeclarationSyntax> TypeDeclarations, ImmutableArray<Blueprint> Blueprints)
		{
			this.Compilation = Compilation;
			this.TypeDeclarations = TypeDeclarations;
			this.Blueprints = Blueprints;
		}
	}
}
