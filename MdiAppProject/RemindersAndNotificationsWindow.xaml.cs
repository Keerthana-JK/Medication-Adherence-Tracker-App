using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using MdiAppProject.ViewModels;

namespace MdiAppProject
{
	/// <summary>
	/// Interaction logic for RemindersAndNotificationsWindow.xaml
	/// </summary>
	public partial class RemindersAndNotificationsWindow : Window
	{
		public ObservableCollection<Reminder> Reminders = new ObservableCollection<Reminder>();
		public RemindersAndNotificationsWindow()
		{
			InitializeComponent();

			lstBoxReminder.ItemsSource = Reminders;
			//DataContext = new RemindersAndNotificationsViewModel();
			DataContext = FormConfig.remindersAndNotificationsViewModel;
		}

	}
}
