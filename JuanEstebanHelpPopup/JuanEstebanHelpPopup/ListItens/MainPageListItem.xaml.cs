using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JuanEstebanHelpPopup.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JuanEstebanHelpPopup.ListItens
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPageListItem : ContentView
	{
		public MainPageListItem ()
		{
			InitializeComponent ();
		}

	    protected override void OnBindingContextChanged()
	    {
	        base.OnBindingContextChanged();

	        if (BindingContext != null)
	        {
	            var funcionalidade = (Funcionalidade) BindingContext;

	            ImageIcon.GestureRecognizers.Add(new TapGestureRecognizer()
	            {
	                Command = funcionalidade.IconeCommand
	            });
            }
	    }
	}
}