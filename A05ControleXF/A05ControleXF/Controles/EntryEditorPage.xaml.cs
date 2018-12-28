using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace A05ControleXF.Controles
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EntryEditorPage : ContentPage
	{
		public EntryEditorPage ()
		{
			InitializeComponent ();

            txt_Idade.TextChanged += delegate (object sender, TextChangedEventArgs args)
            {
                lbl_Duplicado.Text = args.NewTextValue;
            };

            txt_Comentario.Completed += delegate (object sender, EventArgs args)
            {
                lbl_QtdChar.Text = txt_Comentario.Text.Length.ToString();
            };
		}
	}
}