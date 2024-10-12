using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MdiAppProject.ViewModels
{
	public class RemindersAndNotificationsViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		private ObservableCollection<Reminder> _reminders;
		private ObservableCollection<Notification> _notifications;
		private string _selectedFrequency;
		private string _preferredTime;

		public ObservableCollection<Reminder> Reminders
		{
			get => _reminders;
			set
			{
				_reminders = value;
				OnPropertyChanged(nameof(Reminders));
			}
		}

		private void OnPropertyChanged(string v)
		{
			throw new NotImplementedException();
		}

		public ObservableCollection<Notification> Notifications
		{
			get => _notifications;
			set
			{
				_notifications = value;
				OnPropertyChanged(nameof(Notifications));
			}
		}

		public string SelectedFrequency
		{
			get => _selectedFrequency;
			set
			{
				_selectedFrequency = value;
				OnPropertyChanged(nameof(SelectedFrequency));
			}
		}

		public string PreferredTime
		{
			get => _preferredTime;
			set
			{
				_preferredTime = value;
				OnPropertyChanged(nameof(PreferredTime));
			}
		}

		//Command to save settings
		public ICommand SaveSettingsCommand { get; }

		public RemindersAndNotificationsViewModel()
		{
			Reminders = new ObservableCollection<Reminder>();
			Notifications = new ObservableCollection<Notification>();
			LoadRemindersAndNotifications();

			//Initialize to save command
			SaveSettingsCommand = new RelayCommand(SaveSettings);
		}

		private void LoadRemindersAndNotifications()
		{
			//Simulating loading reminders from a db or another source
			Reminders.Add(new Reminder { NotificationType="Medication Reminder", Message="Take your medication", ReminderTime=DateTime.Now.AddMinutes(30) });
			Reminders.Add(new Reminder { NotificationType = "Follow-up Appointment", Message = "Doctor's appointment next week", ReminderTime = DateTime.Now.AddDays(7) });

			//Simulating loading notifications
			Notifications.Add(new Notification { NotificationType="Adherence Report", Message="Your Adherence is 90% this week", SentAt=DateTime.Now});
			Notifications.Add(new Notification { NotificationType ="Message from doctor", Message="Please schedule your next appointment", SentAt = DateTime.Now });
		}

		private void SaveSettings(object obj)
		{
			MessageBox.Show($"Settings saved: \nFrequency: {SelectedFrequency}\nPreferred Time: {PreferredTime}");
		}
	}
}
