using AppBuscaCep1.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppBuscaCep1.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppBuscaCep1.Model;

namespace AppBuscaCep1.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BuscaCepPorLogradouro : ContentPage
    {
        public BuscaCepPorLogradouro()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                carregando.IsRunning = true;

                List<Cep> arr_ceps = await DataService.GetCepsByLogradouro(txt_logradouro.Text);

                lst_ceps.ItemsSource = arr_ceps;
            }
            catch(Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }
            finally
            {
                carregando.IsRunning = false;
            }
        }
    }
}