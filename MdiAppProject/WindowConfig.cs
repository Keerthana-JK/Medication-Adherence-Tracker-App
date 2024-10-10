using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MdiAppProject
{
	public class WindowConfig
	{
		public static Window SignUpWindow { get; set; } = new SignUpWindow();
		public static Window DashboardWindow { get; set; } = new DashboardWindow();
		public static Window LoginWindow { get; set;} = new LoginWindow();
	}
}
