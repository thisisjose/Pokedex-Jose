using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using MVVM_implementacion_JSVE;
using MVVM_implementacion_JSVE.Modelo;

namespace MVVM_implementacion_JSVE.VistaModelo
{
    public class VMpage2 : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        public List<Musuarios> listausuarios { get; set; }
        public void MostraUsuarios()
        {
            listausuarios = new List<Musuarios>
            {
                new Musuarios
                {
                    Nombre="coca",
                    Imagen="https://i.ibb.co/sWqnBCZ/soda.png"
                },
                 new Musuarios
                {
                    Nombre="coco",
                    Imagen="https://i.ibb.co/jWZZNcn/coco.png"
                },
                  new Musuarios
                {
                    Nombre="Jaido",
                    Imagen="https://i.ibb.co/cwtjsYR/hotdog.png"
                }
            };
        }
        #endregion
        #region CONTRUCTOR
        public VMpage2(INavigation navigation)
        {
            Navigation = navigation;
            MostraUsuarios();
        }
        #endregion
        #region OBJETOS
        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }
        #endregion
        #region PROCESOS
        public async Task Volver()
        {
            await Navigation.PopAsync();
        }
        public void ProcesoSimple()
        {

        }
        public async Task Alerta(Musuarios parametros)
        {
            await DisplayAlert("Titulo", parametros.Nombre, "Ok");
        }
        #endregion
        #region COMANDOS
        //public icommand volvercommand => new command(async () => await volver());
        //public icommand procesosimpcommand => new command(procesosimple);
        public ICommand Alertacommand => new Command<Musuarios>(async (p) => await Alerta(p));
        #endregion
    }
}
