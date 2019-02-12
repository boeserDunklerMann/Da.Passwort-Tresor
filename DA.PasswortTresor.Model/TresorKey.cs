using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA.PasswortTresor.Model
{
	public sealed class TresorKey
	{
		public string Password { get; set; } //TODO: Dies hier sicher machen mit "SecurityByteStream" oder so
	}
}
