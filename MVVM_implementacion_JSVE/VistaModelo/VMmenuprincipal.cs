using MVVM_implementacion_JSVE.Modelo;
using MVVM_implementacion_JSVE.Vistas;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM_implementacion_JSVE.VistaModelo
{
    class VMmenuprincipal : BaseViewModel
    {

        #region VARIABLES
        string _N1;
        string _N2;
        string _R;
        public List<Mmenuprincipal> listapaginas { get; set; }
        #endregion

        #region CONSTRUCTOR
        public VMmenuprincipal(INavigation navigation)
        {
            Navigation = navigation;
            MostrarPaginas();
        }

        #endregion



        #region OBJETOS

        public String N1
        {
            get { return _N1; }
            set { SetValue(ref _N1, value); }
        }
        public String N2
        {
            get { return _N2; }
            set { SetValue(ref _N2, value); }
        }
        public String R
        {
            get { return _R; }
            set { SetValue(ref _R, value); }
        }
        #endregion

        #region PROCESOS
        public async Task Volver()
        {
            await Navigation.PopAsync();


        }
        public void Sumar()
        {
            double n1 = 0;
            double n2 = 0;
            double r = 0;

            n1 = Convert.ToDouble(N1);
            n2 = Convert.ToDouble(N2);
            r = Convert.ToDouble(r);

            r = n1 + n2;
            R = r.ToString();

        }



        public void MostrarPaginas()
        {
            listapaginas = new List<Mmenuprincipal>
                {
                    new Mmenuprincipal
                    {
                        Pagina = "Entry, datapicker, picker, label,navegacion",
                        Icono = "https://i.ibb.co/TRFxVb7/bullbasaur.png"
                    },
                    new Mmenuprincipal
                    {
                        Pagina = "CollectionView sin enlace a Base de datos",
                        Icono = " https://i.ibb.co/9npW98c/charmander.png"
                    },
                    new Mmenuprincipal
                    {
                        Pagina = "Crud pokemon",
                        Icono = "https://i.ibb.co/WW8HfBc/pikachu.png "
                    }






                };
        }
        public async Task Navegar(Mmenuprincipal parametros)
        {
            string pagina;
            pagina = parametros.Pagina;
            if (pagina.Contains("Entry, datapiccker"))
            {
                await Navigation.PushAsync(new pagina1());
            }
            if (pagina.Contains("CollectionView sin enlace"))
            {
                await Navigation.PushAsync(new Page2());
            }
            if (pagina.Contains("Crud pokemon"))
            {
                await Navigation.PushAsync(new Crudpokemon());
            }
        }
        #endregion

        #region COMANDOS

        //public ICommand Volvercommand => new Command(async () => await Volver());
        // public ICommand ProcesoSimpcommand => new Command(MostrarPaginas);
        public ICommand Navegarcommand => new Command<Mmenuprincipal>(async (p) => await Navegar(p));
        #endregion

    }
}
