using Akeneo.Serialization;
using Newtonsoft.Json;

namespace Akeneo.Model
{
	public class ReferenceEntityRecordValue
	{
		/// <summary>
		/// Channel code of the reference entity record value
		/// </summary>
		public string Locale { get; set; }

		/// <summary>
		///  Locale code of the reference entity record value
		/// </summary>
		public string Scope { get; set; }

		/// <summary>
		/// The value stored for this attribute for this locale (if attribute is localizable) and this channel (if the attribute is scopable). Its type and format depends on the attribute type.
		/// </summary>
		[JsonConverter(typeof(ReferenceEntityRecordValueDataConverter))]
		public object Data { get; set; }
	}
}