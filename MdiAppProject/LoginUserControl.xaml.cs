using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MdiAppProject
{
	/// <summary>
	/// Interaction logic for LoginUserControl.xaml
	/// </summary>
	public partial class LoginUserControl : UserControl
	{
		public LoginUserControl()
		{
			InitializeComponent();
		}

		private void btnLogin_Click(object sender, RoutedEventArgs e)
		{
			FormConfig.dashboardWindow.Show();
        }

		private void lblSignUp_Click(object sender, RoutedEventArgs e)
		{
			FormConfig.signUpWindow.Show();
		}
	}
}
