using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MdiAppProject
{
	public class MdtViewModel : INotifyPropertyChanged
	{
		//INotifyPropertyChanged implementation
		public event PropertyChangedEventHandler PropertyChanged;
		//Code handling Dashboard
		public ObservableCollection<Medication>Medications {get; set; }
	}
}
