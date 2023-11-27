using MVVM_implementacion_JSVE.Modelo;
using MVVM_implementacion_JSVE.VistaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVM_implementacion_JSVE.Vistas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Menuprincipal : ContentPage
	{
		public Menuprincipal ()
		{
            InitializeComponent();
            BindingContext = new VMmenuprincipal(Navigation);
        }
	}
}