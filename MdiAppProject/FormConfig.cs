using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MdiAppProject
{
	public class FormConfig
	{
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




		static FormConfig()
		{
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
		}
	}
}
