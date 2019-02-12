using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA.PasswortTresor.IO.Declarations;
using DA.PasswortTresor.Model;
using Newtonsoft.Json;

namespace DA.PasswortTresor.IO.Implementations
{
	public class JsonSerializer : ISerialize
	{
		public List<PasswordEntry> DeserializePasswordEntries(object data)
			=> JsonConvert.DeserializeObject<List<PasswordEntry>>(data.ToString());

		public object SerializePasswordEntries(List<PasswordEntry> entries)
			=> JsonConvert.SerializeObject(entries);
	}
}
