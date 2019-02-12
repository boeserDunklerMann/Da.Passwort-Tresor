using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA.PasswortTresor.IO.Declarations
{
	public interface IStorage
	{
		void WriteData(byte[] data, int length);
		byte[] LoadData();
	}
}
