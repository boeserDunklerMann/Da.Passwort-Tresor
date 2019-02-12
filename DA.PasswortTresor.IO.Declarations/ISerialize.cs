using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA.PasswortTresor.Model;

namespace DA.PasswortTresor.IO.Declarations
{
    public interface ISerialize
    {
		object SerializePasswordEntries(List<PasswordEntry> entries);
		List<PasswordEntry> DeserializePasswordEntries(object data);
    }
}
