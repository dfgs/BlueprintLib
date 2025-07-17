using System;
using System.Collections.Generic;
using System.Text;

namespace BlueprintLib.Definitions
{
	public static class DefinitionsExtensions
	{
		public static bool MatchesName(this INamed Item, string Name)
		{
			return (Item.Name == Name) || (Item.Name.Split('.').Last() == Name);
		}
		public static INamed? Find(this IEnumerable<INamed> Item, string Name)
		{
			return Item.FirstOrDefault(item => item.MatchesName(Name));
		}
		public static bool Contains(this IEnumerable<INamed> Items, string Name)
		{
			return Items.Any(item => item.MatchesName(Name));
		}
		
		public static IEnumerable<IAttributeContainer> WithAttribute(this IEnumerable<IAttributeContainer> ClassDefinitions, string Name)
		{
			return ClassDefinitions.Where(item=>item.Attributes.Contains(Name));
		}
		

	}
}
