using Asrefly.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Asrefly.GUI;

namespace Asrefly
{
	public partial class Main : Form
	{
		private readonly PageManager pageManager;
		public Main()
		{
			InitializeComponent();
			pageManager = new PageManager(this);

			// Load home page 
			pageManager.LoadPage(GUI.GUIHome.HomeUserControl1.Instance());
		}
		#region Events 
		private void HomeBtn_Click(object sender, EventArgs e)
		{
			// Load Home Page 
			pageManager.LoadPage(GUI.GUIHome.HomeUserControl1.Instance());
		}
		#endregion
	}
}
