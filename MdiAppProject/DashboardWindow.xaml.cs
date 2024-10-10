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
	/// Interaction logic for DashboardWindow.xaml
	/// </summary>
	public partial class DashboardWindow : Window
	{
		public DashboardWindow()
		{
			InitializeComponent();
			DataContext = new MdtViewModel();
		}

		private void btnLogOut_Click(object sender, RoutedEventArgs e)
		{
			WindowConfig.LoginWindow.Show();
		}

		private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			e.Cancel = true;
			this.Hide();
		}

		private void btnMedicationSchedule_Click(object sender, RoutedEventArgs e)
		{
			FormConfig.medicationScheduleWindow.Show();
		}

		private void btnAdheranceTracking_Click(object sender, RoutedEventArgs e)
		{
			FormConfig.adheranceTrackingWindow.Show();
		}

		private void btnReports_Click(object sender, RoutedEventArgs e)
		{
			FormConfig.reportsWindow.Show();
		}

		private void btnProfile_Click(object sender, RoutedEventArgs e)
		{
			FormConfig.patientProfileWindow.Show();
		}

		private void btnSettings_Click(object sender, RoutedEventArgs e)
		{
			FormConfig.settingsWindow.Show();
		}

		private void btnReminders_Click(object sender, RoutedEventArgs e)
		{
			FormConfig.remindersAndNotificationsWindow.Show();
		}

		private void Window_Closed(object sender, EventArgs e)
		{
			Application.Current.Shutdown();
		}
	}
}
