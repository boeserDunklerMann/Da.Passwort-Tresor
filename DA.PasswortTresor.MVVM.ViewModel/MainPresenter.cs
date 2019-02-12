using DA.PasswortTresor.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DA.PasswortTresor.MVVM.ViewModel
{
    public class MainPresenter : Framework.ObservableObject
    {
		private List<PasswordEntry> _tresor = new List<PasswordEntry>();

		private void LoginAction()
		{

		}

		public ICommand DoLogin
		{ get { return new Framework.DelegateCommand(LoginAction); } }
    }
}
