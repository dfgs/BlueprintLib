using System;
using System.Collections.Generic;
using System.Text;

namespace BlueprintLib.Definitions
{
	public static class DefinitionsExtensions
	{
		public static bool MatchesName(this AttributeDefinition AttributeDefinition, string Name)
		{
			return (AttributeDefinition.Name == Name) || (AttributeDefinition.Name.Split('.').Last() == Name);
		}
		public static AttributeDefinition? Find(this IEnumerable<AttributeDefinition> AttributeDefinitions, string Name)
		{
			return AttributeDefinitions.FirstOrDefault(item => item.MatchesName(Name));
		}
		public static bool Contains(this IEnumerable<AttributeDefinition> AttributeDefinitions, string Name)
		{
			return AttributeDefinitions.Any(item => item.MatchesName(Name));
		}


		public static bool MatchesName(this AttributeParameterDefinition AttributeParameterDefinition, string Name)
		{
			return (AttributeParameterDefinition.Name == Name);
		}
		public static AttributeParameterDefinition? Find(this IEnumerable<AttributeParameterDefinition> AttributeParameterDefinitions, string Name)
		{
			return AttributeParameterDefinitions.FirstOrDefault(item => item.MatchesName(Name));
		}
		public static bool Contains(this IEnumerable<AttributeParameterDefinition> AttributeParameterDefinitions, string Name)
		{
			return AttributeParameterDefinitions.Any(item => item.MatchesName(Name));
		}




		public static IEnumerable<ClassDefinition> WithAttribute(this IEnumerable<ClassDefinition> ClassDefinitions, string Name)
		{
			return ClassDefinitions.Where(item=>item.Attributes.Contains(Name));
		}

		public static IEnumerable<PropertyDefinition> WithAttribute(this IEnumerable<PropertyDefinition> PropertyDefinitions, string Name)
		{
			return PropertyDefinitions.Where(item => item.Attributes.Contains(Name));
		}

	}
}
