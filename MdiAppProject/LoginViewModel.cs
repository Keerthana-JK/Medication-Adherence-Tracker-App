using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MdiAppProject
{
	public class LoginViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		private ICommand _loginCommand;

		public ICommand LoginCommand
		{
			get { return _loginCommand; }
			set { _loginCommand = value; OnPropertyChanged("LoginCommand"); }
		}
		public LoginViewModel()
		{
			LoginCommand = new RelayCommand(obj => ExecuteLoginCommand());
		}

		private void ExecuteLoginCommand()
		{
			// Code to execute when the button is clicked


		}
		protected virtual void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
