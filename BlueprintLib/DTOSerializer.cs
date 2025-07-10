using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace BlueprintLib
{
	public static class DTOSerializer
	{
		public static void Serialize(string Path, DTO DTO)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(DTO));
			using (FileStream stream = new FileStream(Path, FileMode.Create))
			{
				serializer.Serialize(stream, DTO);
			}
		}
		public static DTO Deserialize(string Path)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(DTO));
			DTO dto;

			using (FileStream stream = new FileStream(Path, FileMode.Open))
			{
				dto=(DTO)serializer.Deserialize(stream);
			}
			dto.Name = System.IO.Path.GetFileNameWithoutExtension(Path);
			
			return dto;
		}

	}
}
