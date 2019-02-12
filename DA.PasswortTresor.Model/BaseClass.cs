using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA.PasswortTresor.Model
{
	/// <summary>
	/// Baseclass for the Datamodel
	/// </summary>
    public abstract class BaseClass
    {
		public int Id { get; set; } = 0;
		public bool IsNew { get => Id == 0; }
	}
}
