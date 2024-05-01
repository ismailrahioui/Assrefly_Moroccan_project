using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asrefly.GUI.GUIHome
{
	public partial class HomeUserControl1 : UserControl
	{
		public static HomeUserControl1 _HomeUserControl1;
		public HomeUserControl1()
		{
			InitializeComponent();
		}
		public static HomeUserControl1 Instance() 
		{
			return _HomeUserControl1 ?? (new HomeUserControl1());
		}
	}
}
