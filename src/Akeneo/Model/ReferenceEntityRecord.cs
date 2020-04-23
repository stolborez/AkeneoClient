using System.Collections.Generic;

namespace Akeneo.Model
{
	public class ReferenceEntityRecord : ModelBase
	{
		/// <summary>
		///  Code of the record
		/// </summary>
		public string Code { get; set; }

		/// <summary>
		///  ReferenceEntityRecord attributes values
		/// </summary>
		public Dictionary<string, List<ReferenceEntityRecordValue>> Values { get; set; }

        public ReferenceEntityRecord()
		{
            Values = new Dictionary<string, List<ReferenceEntityRecordValue>>();
		}
	}
}
