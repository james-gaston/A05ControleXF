using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace A05ControleXF.Menu
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Master : MasterDetailPage
	{
        private NavigationPage nav { get; set; }

        public Master ()
		{
			InitializeComponent ();
            nav = new NavigationPage();
            Detail = nav;
            nav.Navigation.PushAsync(new MainPage());
		}

        private async void PushAsyncToRoot(NavigationPage nav, Page newPage)
        {
            nav.Navigation.InsertPageBefore(newPage, nav.Navigation.NavigationStack[0]);
            await nav.Navigation.PopToRootAsync();
            IsPresented=false;
        }

        private void GoMainPage(object sender, EventArgs args)
        {
            PushAsyncToRoot(nav, new MainPage());
        }

        private void GoActivityIndicatorPage(object sender, EventArgs args)
        {
            PushAsyncToRoot(nav, new Controles.ActivityIndicatorPage());
        }

        private void GoProgressBarPage(object sender, EventArgs args)
        {
            PushAsyncToRoot(nav, new Controles.ProgressBarPage());
        }

        private void GoBoxViewPage(object sender, EventArgs args)
        {
            PushAsyncToRoot(nav, new Controles.BoxViewPage());
        }

        private void GoLabelPage(object sender, EventArgs args)
        {
            PushAsyncToRoot(nav, new Controles.LabelPage());
        }

        private void GoButtonPage(object sender, EventArgs args)
        {
            PushAsyncToRoot(nav, new Controles.ButtonPage());
        }

        private void GoEntryEditorPage(object sender, EventArgs args)
        {
            PushAsyncToRoot(nav, new Controles.EntryEditorPage());
        }
        
        private void GoDatePickerPage(object sender, EventArgs args)
        {
            PushAsyncToRoot(nav, new Controles.DatePickerPage());
        }
        
        private void GoTimePickerPage(object sender, EventArgs args)
        {
            PushAsyncToRoot(nav, new Controles.TimePickerPage());
        }
        
        private void GoPickerPage(object sender, EventArgs args)
        {
            PushAsyncToRoot(nav, new Controles.PickerPage());
        }
        
        private void GoSearchBarPage(object sender, EventArgs args)
        {
            PushAsyncToRoot(nav, new Controles.SearchBarPage());
        }
        
        private void GoSliderStepperPage(object sender, EventArgs args)
        {
            PushAsyncToRoot(nav, new Controles.SliderStepperPage());
        }
        
        private void GoSwitchPage(object sender, EventArgs args)
        {
            PushAsyncToRoot(nav, new Controles.SwitchPage());
        }
        
        private void GoImagePage(object sender, EventArgs args)
        {
            PushAsyncToRoot(nav, new Controles.ImagePage());
        }

    }
}