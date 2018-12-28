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
	public partial class SearchBarPage : ContentPage
	{
        private List<String> empresasTi;


        public SearchBarPage ()
		{
			InitializeComponent ();

            empresasTi = new List<string>();
            empresasTi.Add("Microsoft");
            empresasTi.Add("Google");
            empresasTi.Add("Apple");
            empresasTi.Add("Oracle");
            empresasTi.Add("Tesla");
            empresasTi.Add("IBM");
            empresasTi.Add("Xiaomi");

            Preencher(empresasTi);
		}

        private void Preencher(List<String> list)
        {
            ListResult.Children.Clear();
            foreach (var element in list)
            {
                ListResult.Children.Add(new Label { Text = element });
            }
        }

        private void PesquisarButton(object sender, EventArgs args)
        {
            var resultado = empresasTi.Where(a => a.Contains(((SearchBar)sender).Text)).ToList<String>();
            Preencher(resultado);
        }

        private void Pesquisar(object sender, TextChangedEventArgs args)
        {
            var resultado = empresasTi.Where(a => a.Contains(args.NewTextValue)).ToList<String>();
            Preencher(resultado);
        }
	}
}