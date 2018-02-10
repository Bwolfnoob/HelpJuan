using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JuanEstebanHelpPopup
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NamePhonePopUp 
	{
		public NamePhonePopUp ()
		{
			InitializeComponent ();
		}
	    private async void Close_OnClicked(object sender, EventArgs e)
	    {
	      await  PopupNavigation.PopAsync();
	    }
	}
}