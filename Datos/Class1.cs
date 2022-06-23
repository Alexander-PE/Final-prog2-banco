using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class Class1
    {
        bancoEntities bd = new bancoEntities();

        public void InsertarUsuarios(usuario xx)
        {
            bd.usuarios.Add(xx);
            bd.SaveChanges();
        }

        public void crearCuenta(cuenta x)
        {
            bd.cuentas.Add(x);
            bd.SaveChanges();
        }

        public void crearTarjeta(Tcredito a)
        {
            bd.Tcreditoes.Add(a);
            bd.SaveChanges();
        }

        public void crearPrestamo(prestamo a)
        {
            bd.prestamoes.Add(a);
            bd.SaveChanges();
        }

        public void inggP(string x, int a) //ingresos prestamo
        {
            bd.ingresosPP(x, a);
            bd.SaveChanges();
        }

        public void inggN(string x, int a) //ingresos normales
        {
            bd.ingresosNN(x, a);
            bd.SaveChanges();
        }

        public void pagarP(string x, int a, int s)
        {
            bd.prestamosss(x, a, s);
            bd.SaveChanges();
        }

        public void retirar(string x, int a)
        {
            bd.retirossse(x, a);
            bd.SaveChanges();
        }
        public void avance(string x, int s)
        {
            bd.avances(x, s);
            bd.SaveChanges();
        }
        public void transf(string x, string a, int s)
        {
            bd.tranferenciaaaa(x,a,s);
            bd.SaveChanges();
        }







        public usuario verificar(string Cedula, string Clave)
        {
            return (from d in bd.usuarios where d.Cedula == Cedula.Trim() && d.Clave == Clave.Trim() select d).FirstOrDefault();
        }

        public cuenta datos(string cedula)
        {
            return (from x in bd.cuentas where x.cNumero == cedula.Trim() select x).FirstOrDefault();
        }

        public Tcredito comprobar(string cedula)
        {
            return (from x in bd.Tcreditoes where x.Tnumero == cedula.Trim() select x).FirstOrDefault();
        }

        public List<Tcredito> tarjetas(string a)
        {
            return (from x in bd.Tcreditoes where x.Tnumero == a.Trim() select x).ToList();
        }

        public List<uso> historialC(string x)
        {
            return (from a in bd.usos where a.Cuenta == x.Trim() select a).ToList();
        }
        public List<prestamo> prestamosss(string x)
        {
            return (from a in bd.prestamoes where a.cuenta == x.Trim() select a).ToList();
        }
        public List<prestamoHistorial> HistorialP(string x)
        {
            return (from a in bd.prestamoHistorials where a.cuenta == x.Trim() select a).ToList();
        }





        public List<usuario> gente()
        {
            return bd.usuarios.ToList();
        }
        public List<cuenta> genteC()
        {
            return bd.cuentas.ToList();
        }
        public List<Tcredito> genteT()
        {
            return bd.Tcreditoes.ToList();
        }
        public List<prestamo> genteP()
        {
            return bd.prestamoes.ToList();
        }






        // editar y eliminar clientes
        public void editarrrU(usuario ee)
        {
            var x = bd.usuarios.Find(ee.id);
            x.Nombre = ee.Nombre;
            x.Apellidos = ee.Apellidos;
            x.Correo = ee.Correo;
            x.rol= ee.rol;
            bd.SaveChanges();
        }

        public void eliminarU(int id)
        {
            var g = bd.usuarios.Find(id);
            bd.usuarios.Remove(g);
            bd.SaveChanges();
        }


        // editar y eliminar cuentas
        public void editarrrC(cuenta ee)
        {
            var x = bd.cuentas.Find(ee.id);
            x.cNumero = ee.cNumero;
            x.cSaldo = ee.cSaldo;
            x.propietario = ee.propietario;
            bd.SaveChanges();
        }
        public void eliminarC(int id)
        {
            var g = bd.cuentas.Find(id);
            bd.cuentas.Remove(g);
            bd.SaveChanges();
        }


        // editar y eliminar tarjetas
        public void editarrrT(Tcredito ee)
        {
            var x = bd.Tcreditoes.Find(ee.id);
            x.propietario = ee.propietario;
            x.Tnumero = ee.Tnumero;
            bd.SaveChanges();
        }
        public void eliminarT(int id)
        {
            var g = bd.Tcreditoes.Find(id);
            bd.Tcreditoes.Remove(g);
            bd.SaveChanges();
        }

        // editar y eliminar prestamos
        public void editarrrP(prestamo ee)
        {
            var x = bd.prestamoes.Find(ee.id);
            x.cuenta = ee.cuenta;
            x.monto = ee.monto;
            x.montoPagado = ee.montoPagado;
            bd.SaveChanges();
        }
        public void eliminarP(int id)
        {
            var g = bd.prestamoes.Find(id);
            bd.prestamoes.Remove(g);
            bd.SaveChanges();
        }



        // tomar un usuario dpd cedula
        public usuario tomar(string id)
        {
            return bd.usuarios.Where(x => x.Cedula == id.Trim()).FirstOrDefault();
        }

    }
}