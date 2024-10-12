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
			
			RemindersListBox.ItemsSource = Reminders;
			LoadReminders();
		}

		private void LoadReminders()
		{
			// Simulating loading reminders from a database or another source
			Reminders.Add(new Reminder { NotificationType = "Medication Reminder", Message = "Take your medication.", ReminderTime = DateTime.Now.AddMinutes(30) });
			Reminders.Add(new Reminder { NotificationType = "Follow-up Appointment", Message = "Doctor's appointment next week.", ReminderTime = DateTime.Now.AddDays(7) });
			// Add more reminders as needed
		}

		private void SaveSettings()
		{
			// Here you would save the settings (frequency and preferred time)
			string frequency = (FrequencyComboBox.SelectedItem as ComboBoxItem)?.Content.ToString();
			string preferredTime = PreferredTimeTextBox.Text;

			// Implement saving logic (e.g., to a database or settings file)
			MessageBox.Show($"Settings Saved:\nFrequency: {frequency}\nPreferred Time: {preferredTime}");
		}

	}
}
