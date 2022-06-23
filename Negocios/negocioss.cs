using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocios
{
    public class negocioss
    {
        Class1 cdatos = new Class1();



        public void crearTarjeta(Tcredito a)
        {
            cdatos.crearTarjeta(a);
        }

        public void SetCliente(usuario param)
        {
            cdatos.InsertarUsuarios(param);
        }

        public void crearPrestamo(prestamo a)
        {
            cdatos.crearPrestamo(a);
        }

        public void pagarP(string x, int a, int s)
        {
            cdatos.pagarP(x,a,s);
        }

        public void transf(string x, string a, int s)
        {
            cdatos.transf(x, a, s);
        }
        public void inggP(string x, int a)
        {
            cdatos.inggP(x, a);
        }
        public void inggN(string x, int a)
        {
            cdatos.inggN(x, a);
        }
        public void retirar(string x, int a)
        {
            cdatos.retirar(x, a);
        }
        public void avance(string x, int a)
        {
            cdatos.avance(x, a);
        }



        public usuario verificar(string a, string b)
        {
            return cdatos.verificar(a, b);
        }

        public cuenta datos(string x)
        {
            return cdatos.datos(x);
        }

        public void setCuenta(cuenta a)
        {
            cdatos.crearCuenta(a);
        }


        public Tcredito comprobar(string z)
        {
            return cdatos.comprobar(z);
        }




        
        public List<uso> historialC(string x)
        {
            return cdatos.historialC(x);
        }
        public List<prestamo> prestamosss(string x)
        {
            return cdatos.prestamosss(x);
        }
        public List<prestamoHistorial> HistorialP(string x)
        {
            return cdatos.HistorialP(x);
        }
        public List<Tcredito> tarjetas(string a)
        {
            return cdatos.tarjetas(a);
        }








        // para ver las personas, sus cuentas y tarjetas
        public List<usuario> gente()
        {
            return cdatos.gente();
        }
        public List<cuenta> genteC()
        {
            return cdatos.genteC();
        }
        public List<Tcredito> genteT()
        {
            return cdatos.genteT();
        }
        public List<prestamo> genteP()
        {
            return cdatos.genteP();
        }







        // tomar datos para el crud
        public usuario tomar(string id)
        {
            return cdatos.tomar(id);
        }



        // editar y eliminar usuarios
        public void editarrrU(usuario ee)
        {
            cdatos.editarrrU(ee);
        }
        public void eliminarU(int id)
        {
            cdatos.eliminarU(id);
        }


        // editar y eliminar cuentas
        public void editarrrC(cuenta ee)
        {
            cdatos.editarrrC(ee);
        }
        public void eliminarC(int id)
        {
            cdatos.eliminarC(id);
        }



        // editar y eliminar tarjetas
        public void editarrrT(Tcredito ee)
        {
            cdatos.editarrrT(ee);
        }
        public void eliminarT(int id)
        {
            cdatos.eliminarT(id);
        }



        // editar y eliminar prestamos
        public void editarrrP(prestamo ee)
        {
            cdatos.editarrrP(ee);
        }
        public void eliminarP(int id)
        {
            cdatos.eliminarT(id);
        }
    }
}
