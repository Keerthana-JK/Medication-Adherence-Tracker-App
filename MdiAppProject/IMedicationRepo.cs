using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace MdiAppProject
{
	public interface IMedicationRepo
	{
		void Create(Medication medication);
		void Update(Medication medication);
		void Delete(Medication medication);
		ObservableCollection<Medication> ReadAll();
	}
}
