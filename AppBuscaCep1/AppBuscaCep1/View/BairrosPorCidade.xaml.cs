using AppBuscaCep1.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBuscaCep1.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BairrosPorCidade : ContentPage
    {
        ObservableCollection<Cidade> lista_cidades = new ObservableCollection<Cidade> ();


        public BairrosPorCidade()
        {
            InitializeComponent();
        }

        private void pck_estado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}