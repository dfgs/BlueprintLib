using System;
using System.Collections.Generic;
using System.Text;

namespace BlueprintLib.Definitions
{
	public static class DefinitionsExtensions
	{
		public static bool MatchesName(this INamed Item, string Name)
		{
			if (Item == null) return false;
			return (Item.Name == Name) || (Item.Name.Split('.').Last() == Name);
		}
		public static INamed? Find(this IEnumerable<INamed> Items, string Name)
		{
			if (Items == null) return null;
			return Items.FirstOrDefault(item => item.MatchesName(Name));
		}
		public static bool Contains(this IEnumerable<INamed> Items, string Name)
		{
			if (Items == null) return false;
			return Items.Any(item => item.MatchesName(Name));
		}
		
		public static IEnumerable<IAttributeContainer>? WithAttribute(this IEnumerable<IAttributeContainer> Items, string Name)
		{
			if (Items == null) return null;
			return Items.Where(item=>item.Attributes.Contains(Name));
		}
		

	}
}
