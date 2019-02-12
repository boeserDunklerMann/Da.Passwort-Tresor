using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA.PasswortTresor.Model
{
	public sealed class PasswordEntry : BaseClass
	{
		public string Site { get; set; }
		public string Login { get; set; }
		public string Password { get; set; } //TODO: Dies hier sicher machen mit "SecurityByteStream" oder so
	}
}
