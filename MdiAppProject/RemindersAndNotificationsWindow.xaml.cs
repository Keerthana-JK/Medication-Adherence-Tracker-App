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
using System.Windows.Shapes;

namespace MdiAppProject
{
	/// <summary>
	/// Interaction logic for RemindersAndNotificationsWindow.xaml
	/// </summary>
	public partial class RemindersAndNotificationsWindow : Window
	{
		public RemindersAndNotificationsWindow()
		{
			InitializeComponent();
		}

		private void btnCheckIn_Click(object sender, RoutedEventArgs e)
		{
			FormConfig.checkIn.Show();
        }
    }
}
