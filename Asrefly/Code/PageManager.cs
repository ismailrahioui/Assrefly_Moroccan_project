using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asrefly.Code
{
	class PageManager
	{
		private readonly Main main;
		public PageManager(Main main)
		{
			this.main = main;
		}
		public void LoadPage(UserControl PageUserControl) 
		{
			// Load old page 
			var OldPage = main.panelcontainer.Controls.OfType<UserControl>().FirstOrDefault();
			if(OldPage != null)
			{
				main.panelcontainer.Controls.Remove(OldPage); // Remove old page 
				OldPage.Dispose();
			}
			// Load on current page 
			PageUserControl.Dock = DockStyle.Fill;
			main.panelcontainer.Controls.Add(PageUserControl);

		}
	}
}
