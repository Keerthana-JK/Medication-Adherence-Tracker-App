using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MdiAppProject.ViewModels;

namespace MdiAppProject
{
	public class FormConfig
	{
		//ViewModels
		public static AddMedicationViewModel addMedicationViewModel = null;
		public static AdherenceTrackingViewModel adherenceTrackingViewModel = null;
		public static CheckInViewModel checkInViewModel = null;
		public static DashboardViewModel dashboardViewModel = null;
		public static DoctorViewModel doctorViewModel = null;
		public static MedicationScheduleViewModel medicationScheduleViewModel = null;
		public static PatientProfileViewModel patientProfileViewModel = null;
		public static RemindersAndNotificationsViewModel remindersAndNotificationsViewModel = null;
		public static ReportsViewModel reportsViewModel = null;
		public static SettingsViewModel settingsViewModel = null;
		//Windows
		public static SignUpWindow signUpWindow = null;
		public static LoginWindow loginWindow = null;
		public static DashboardWindow dashboardWindow = null;
		public static AddMedicationWindow addMedicationWindow = null;
		public static MedicationScheduleWindow medicationScheduleWindow = null;
		public static AdherenceTrackingWindow adheranceTrackingWindow = null;
		public static RemindersAndNotificationsWindow remindersAndNotificationsWindow = null;
		public static CheckInWindow checkIn = null;
		public static PatientProfileWindow patientProfileWindow = null;
		public static DoctorWindow doctorWindow = null;
		public static ReportsWindow reportsWindow = null;
		public static SettingsWindow settingsWindow = null;
		public static MedicationWindow medicationWindow = null;


		static FormConfig()
		{
			addMedicationViewModel = new AddMedicationViewModel();
			adherenceTrackingViewModel = new AdherenceTrackingViewModel();
			checkInViewModel = new CheckInViewModel();
			dashboardViewModel = new DashboardViewModel();
			doctorViewModel = new DoctorViewModel();
			medicationScheduleViewModel = new MedicationScheduleViewModel();
			patientProfileViewModel = new PatientProfileViewModel();
			remindersAndNotificationsViewModel = new RemindersAndNotificationsViewModel();
			reportsViewModel = new ReportsViewModel();
			settingsViewModel = new SettingsViewModel();

			signUpWindow = new SignUpWindow();
			loginWindow = new LoginWindow();
			dashboardWindow = new DashboardWindow();
			addMedicationWindow = new AddMedicationWindow();
			medicationScheduleWindow = new MedicationScheduleWindow();
			adheranceTrackingWindow = new AdherenceTrackingWindow();
			remindersAndNotificationsWindow = new RemindersAndNotificationsWindow();
			checkIn = new CheckInWindow();
			patientProfileWindow = new PatientProfileWindow();
			doctorWindow = new DoctorWindow();
			reportsWindow = new ReportsWindow();
			settingsWindow = new SettingsWindow();
			medicationWindow = new MedicationWindow();
		}
	}
}
