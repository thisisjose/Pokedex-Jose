using System;
using System.Collections.Generic;
using System.Text;
using Firebase.Database;

namespace MVVM_implementacion_JSVE.Conexion
{
    public class Cconexion
    {
        public static FirebaseClient firebase = new FirebaseClient("https://mvvmjsve-default-rtdb.firebaseio.com/");
    }
}
