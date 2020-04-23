using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Akeneo.Serialization
{
	public class ReferenceEntityRecordValueDataConverter : JsonConverter
	{
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			serializer.Serialize(writer, value);
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			if (reader.TokenType == JsonToken.String)
			{
				if (float.TryParse((string)reader.Value, out float number))
				{
					return number;
				}
				return reader.Value;
			}

			if (reader.TokenType == JsonToken.Boolean)
			{
				return reader.Value;
			}

            if (reader.TokenType == JsonToken.StartArray)
			{
				var array = JArray.Load(reader);
				if (!array.HasValues)
				{
					return Enumerable.Empty<object>();
				}
				if (array.First.Type == JTokenType.String)
				{
					return array.ToObject<List<string>>(serializer);
				}
            }

			return reader.Value;
		}

        public override bool CanConvert(Type objectType)
		{
			return true;
		}
	}
}
