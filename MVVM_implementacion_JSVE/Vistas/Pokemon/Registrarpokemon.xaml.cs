using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MVVM_implementacion_JSVE.VistaModelo.VMpokemon;

namespace MVVM_implementacion_JSVE.Vistas.Pokemon
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registrarpokemon : ContentPage
    {
        public Registrarpokemon()
        {
            InitializeComponent();
            BindingContext = new VMregistropokemon(Navigation);
        }
    }
}