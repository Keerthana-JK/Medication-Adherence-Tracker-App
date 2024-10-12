using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace MdiAppProject
{
	public class MedicationMemoryRepo : IMedicationRepo
	{
		private static MedicationMemoryRepo _instance;
		private ObservableCollection<Medication> medications;

		private MedicationMemoryRepo()
		{
			medications = new ObservableCollection<Medication>();
			InitializeMedications();
		}

		public void InitializeMedications()
		{
			
		}

		//Create
		public void Create(Medication medication)
		{
			throw new NotImplementedException();
		}

		//ReadAll
		public ObservableCollection<Medication> ReadAll()
		{
			throw new NotImplementedException();
		}

		//Update
		public void Update(Medication medication)
		{
			throw new NotImplementedException();
		}

		//Delete
		public void Delete(Medication medication)
		{
			throw new NotImplementedException();
		}
	}
}
