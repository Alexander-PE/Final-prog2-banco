using Entidades;
using Negocios;
using System.Web.Mvc;
using System.Net;
using System;

namespace Pagina.Controllers
{
    public class HomeController : Controller
    {
        negocioss nego = new negocioss();
        public static usuario activo;

        // login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string user, string pass)
        {
            try
            {
                var xx = nego.verificar(user, pass);

                if(xx == null)
                {
                    ViewBag.Error = "usuario o pass invalida";
                    return View();
                }
                Session["user"] = xx;
                activo = xx;

                if (xx.rol == 2)
                {
                    return RedirectToAction("clientes", "Home");
                }
                return RedirectToAction("administrador" , "Home");
            }
            catch (Exception e)
            {
                ViewBag.Error = e.Message;
                return View();
            }
        }

        // registrar personas
        public ActionResult Formulario()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Formulario(usuario obj)
        {
            obj.rol = 2;
            nego.SetCliente(obj);

            return View();
        }




        //clientes sin tarjeta
        public ActionResult clientes()
        {
            if (activo == null)
            {
                return RedirectToAction("Index", "Home");
            }

            var z = nego.datos(activo.Cedula);
            return View(z);
        }



        // tabla del historial de cuenta                    AQUI QUEDE CON EL CLIENTE Y PASE AL ADMIN
        public ActionResult consultarCuenta()  // me deja ver cada uso de mi cuenta y tarjeta
        {
            if (activo == null)
            {
                return RedirectToAction("Index", "Home");
            }
            var x = nego.historialC(activo.Cedula);
            return View(x);
        }

        public ActionResult consultarPrestamos() // para ver el balance de la tarjeta
        {
            if (activo == null)
            {
                return RedirectToAction("Index", "Home");
            }
            var x = nego.prestamosss(activo.Cedula);
            if (x == null)
            {
                return RedirectToAction("clientes");
            }
            return View(x);
        }

        public ActionResult consultarTarjeta() // para ver el balance de la tarjeta
        {
            if (activo == null)
            {
                return RedirectToAction("Index", "Home");
            }
            var x = nego.tarjetas(activo.Cedula);
            return View(x);
        }





        public ActionResult historialPrestamos()  // me deja ver cada uso de mi cuenta y tarjeta
        {
            if (activo == null)
            {
                return RedirectToAction("Index", "Home");
            }
            var x = nego.HistorialP(activo.Cedula);
            return View(x);
        }



        // modulo admin
        public ActionResult administrador()
        {
            if (activo == null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }


        // consultar a las personas, cuentas y tarjetas
        public ActionResult consultarGente()
        {
            if (activo == null)
            {
                return RedirectToAction("Index", "Home");
            }
            var x = nego.gente();
            if (x == null)
            {
                return RedirectToAction("administrador");
            }
            return View(x);
        }
        public ActionResult consultarGenteC() // FALTA CREAR CUENTA Y CREAR TARJETA
        {
            if (activo == null)
            {
                return RedirectToAction("Index", "Home");
            }
            var x = nego.genteC();
            if (x == null)
            {
                return RedirectToAction("administrador");
            }
            return View(x);
        }
        public ActionResult consultarGenteT()
        {
            if (activo == null)
            {
                return RedirectToAction("Index", "Home");
            }
            var x = nego.genteT();
            if (x == null)
            {
                return RedirectToAction("administrador");
            }
            return View(x);
        }

        public ActionResult consultarGenteP()
        {
            if (activo == null)
            {
                return RedirectToAction("Index", "Home");
            }
            var x = nego.genteP();
            if (x == null)
            {
                return RedirectToAction("administrador");
            }
            return View(x);
        }



        // editar y eliminar usuarios
        public ActionResult EditarrrU(string id)
        {
            if (activo == null)
            {
                return RedirectToAction("Index", "Home");
            }
            var xx = nego.tomar(id);
            return View(xx);
        }

        [HttpPost]
        public ActionResult EditarrrU(usuario ee)
        {
            nego.editarrrU(ee);
            return RedirectToAction("administrador");
        }


        public ActionResult eliminarU(int? id)
        {
            if (activo == null)
            {
                return RedirectToAction("Index", "Home");
            }

            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var est = nego.tomar(id.Value.ToString());
            return View(est);
        }

        [HttpPost]
        public ActionResult eliminarU(int id)
        {
            negocioss negg = new negocioss();
            negg.eliminarU(id);
            return RedirectToAction("administrador");
        }







        // registrar cuentas
        public ActionResult FormularioC()
        {
            if (activo == null)
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        [HttpPost]
        public ActionResult FormularioC(cuenta obj)
        {
            var ee = nego.tomar(obj.cNumero);
            if(obj.cNumero == ee.Cedula)
            {
                nego.setCuenta(obj);
                return RedirectToAction("administrador");
            }
            return View();
        }
        // editar y eliminar cuentas
        public ActionResult EditarrrC(string id)
        {
            if (activo == null)
            {
                return RedirectToAction("Index", "Home");
            }
            var xx = nego.tomar(id);
            return View(xx);
        }

        [HttpPost]
        public ActionResult EditarrrC(cuenta ee)
        {
            nego.editarrrC(ee);
            return RedirectToAction("administrador");
        }


        public ActionResult eliminarC(int? id)
        {
            if (activo == null)
            {
                return RedirectToAction("Index", "Home");
            }
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var est = nego.tomar(id.Value.ToString());
            return View(est);
        }

        [HttpPost]
        public ActionResult eliminarC(int id)
        {
            negocioss negg = new negocioss();
            negg.eliminarC(id);
            return RedirectToAction("administrador");
        }




        // registrar tarjetas
        public ActionResult FormularioT()
        {
            if (activo == null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [HttpPost]
        public ActionResult FormularioT(Tcredito obj)
        {
            var z = nego.datos(obj.Tnumero);
            if(obj.Tnumero == z.cNumero)
            {
                obj.Saldo = 0;
                obj.propietario = z.propietario;
                nego.crearTarjeta(obj);
                return RedirectToAction("administrador");
            }
            return View();
        }

        // editar y eliminar tarjetas
        public ActionResult EditarrrT(string id)
        {
            if (activo == null)
            {
                return RedirectToAction("Index", "Home");
            }
            var xx = nego.tomar(id);
            return View(xx);
        }

        [HttpPost]
        public ActionResult EditarrrT(Tcredito ee)
        {
            nego.editarrrT(ee);
            return RedirectToAction("administrador");
        }

        public ActionResult eliminarT(int? id)
        {
            if (activo == null)
            {
                return RedirectToAction("Index", "Home");
            }
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var est = nego.tomar(id.Value.ToString());
            return View(est);
        }

        [HttpPost]
        public ActionResult eliminarT(int id)
        {
            negocioss negg = new negocioss();
            negg.eliminarT(id);
            return RedirectToAction("administrador");
        }






        // registrar prestamos
        public ActionResult FormularioP()
        {
            if (activo == null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [HttpPost]
        public ActionResult FormularioP(prestamo obj)
        {
            var z = nego.datos(obj.cuenta);

            if (obj.cuenta == z.cNumero)
            {
                obj.montoPagado = 0;
                nego.crearPrestamo(obj);
                nego.inggP(z.cNumero, obj.monto);

                return RedirectToAction("administrador", "Home");
            }
            return View();
        }

        // editar y eliminar prestamos
        public ActionResult EditarrrP(string id)
        {
            if (activo == null)
            {
                return RedirectToAction("Index", "Home");
            }
            var xx = nego.tomar(id);
            return View(xx);
        }

        [HttpPost]
        public ActionResult EditarrrP(prestamo ee)
        {
            nego.editarrrP(ee);
            return RedirectToAction("administrador");
        }




        public ActionResult eliminarP(int? id)
        {
            if (activo == null)
            {
                return RedirectToAction("Index", "Home");
            }
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var est = nego.tomar(id.Value.ToString());
            return View(est);
        }

        [HttpPost]
        public ActionResult eliminarP(int id)
        {
            negocioss negg = new negocioss();
            negg.eliminarP(id);
            return RedirectToAction("administrador");
        }





        // pagar prestamo
        public ActionResult pagarP()
        {
            if (activo == null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [HttpPost]
        public ActionResult pagarP(prestamo x)
        {
            // action result de pagar
            nego.pagarP(activo.Cedula, x.id, x.monto);
            return RedirectToAction("clientes");
        }



        public ActionResult transferir()
        {
            if (activo == null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        [HttpPost]
        public ActionResult transferir(transaccione x)
        {
            var z = nego.datos(activo.Cedula);
            // action result de pagar
            if (x.monto < z.cSaldo)
            {
                nego.transf(activo.Cedula, x.cDestino, x.monto);
            }
            return RedirectToAction("clientes");
        }





        public ActionResult FormularioI(string kk)
        {
            if (activo == null)
            {
                return RedirectToAction("Index", "Home");
            }
            var xx = nego.tomar(kk);
            return View(xx);
        }

        [HttpPost]
        public ActionResult FormularioI(cuenta obj)
        {
            nego.inggP(obj.cNumero, (int)obj.cSaldo);
            return RedirectToAction("administrador", "Home");
        }


        public ActionResult avance(string kk)
        {
            if (activo == null)
            {
                return RedirectToAction("Index", "Home");
            }
            var xx = nego.tomar(kk);
            return View(xx);
        }
        [HttpPost]
        public ActionResult avance(cuenta x)
        {
            // action result de pagar
            nego.avance(activo.Cedula, (int)x.cSaldo);
            return RedirectToAction("clientes");
        }




        public ActionResult retirar()
        {
            if (activo == null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        [HttpPost]
        public ActionResult retirar(cuenta x)
        {
            // action result de pagar
            nego.retirar(activo.Cedula, (int)x.cSaldo);
            return RedirectToAction("clientes");
        }

    }
}