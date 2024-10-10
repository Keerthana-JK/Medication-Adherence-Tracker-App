using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MdiAppProject
{
	public class Medication
	{
		public string MedicationName { get; set; }
		public string Dosage { get; set; }
		public DateTime ScheduledTime { get; set; }
		public string Status { get; set; }
		public bool CanMarkAsTaken { get; set; }
		public ICommand MarkAsTakenCommand { get; set; }

		public Medication()
		{
			MarkAsTakenCommand = new RelayCommand(MarkAsTaken);
		}
		private void MarkAsTaken(object parameter)
		{
			Status = "Taken";
			CanMarkAsTaken = false;
			//update datasource (db, etc.)
		}
	}
}
