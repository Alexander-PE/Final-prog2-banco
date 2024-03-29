﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    using Entidades;
    
    public partial class bancoEntities : DbContext
    {
        public bancoEntities()
            : base("name=bancoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<transaccione> transacciones { get; set; }
        public virtual DbSet<usuario> usuarios { get; set; }
        public virtual DbSet<cuenta> cuentas { get; set; }
        public virtual DbSet<prestamo> prestamoes { get; set; }
        public virtual DbSet<prestamoHistorial> prestamoHistorials { get; set; }
        public virtual DbSet<uso> usos { get; set; }
        public virtual DbSet<Tcredito> Tcreditoes { get; set; }
    
        public virtual ObjectResult<consultar_Result> consultar(string acc)
        {
            var accParameter = acc != null ?
                new ObjectParameter("acc", acc) :
                new ObjectParameter("acc", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<consultar_Result>("consultar", accParameter);
        }
    
        public virtual int tranferenciaa(string idC, string idD, Nullable<int> dinero)
        {
            var idCParameter = idC != null ?
                new ObjectParameter("idC", idC) :
                new ObjectParameter("idC", typeof(string));
    
            var idDParameter = idD != null ?
                new ObjectParameter("idD", idD) :
                new ObjectParameter("idD", typeof(string));
    
            var dineroParameter = dinero.HasValue ?
                new ObjectParameter("dinero", dinero) :
                new ObjectParameter("dinero", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("tranferenciaa", idCParameter, idDParameter, dineroParameter);
        }
    
        public virtual int prestamoo(string cue, Nullable<int> idd, Nullable<int> dinero)
        {
            var cueParameter = cue != null ?
                new ObjectParameter("cue", cue) :
                new ObjectParameter("cue", typeof(string));
    
            var iddParameter = idd.HasValue ?
                new ObjectParameter("idd", idd) :
                new ObjectParameter("idd", typeof(int));
    
            var dineroParameter = dinero.HasValue ?
                new ObjectParameter("dinero", dinero) :
                new ObjectParameter("dinero", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("prestamoo", cueParameter, iddParameter, dineroParameter);
        }
    
        public virtual int tranferenciaaaa(string idC, string idD, Nullable<int> dinero)
        {
            var idCParameter = idC != null ?
                new ObjectParameter("idC", idC) :
                new ObjectParameter("idC", typeof(string));
    
            var idDParameter = idD != null ?
                new ObjectParameter("idD", idD) :
                new ObjectParameter("idD", typeof(string));
    
            var dineroParameter = dinero.HasValue ?
                new ObjectParameter("dinero", dinero) :
                new ObjectParameter("dinero", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("tranferenciaaaa", idCParameter, idDParameter, dineroParameter);
        }
    
        public virtual int prestamosss(string cue, Nullable<int> idd, Nullable<int> dinero)
        {
            var cueParameter = cue != null ?
                new ObjectParameter("cue", cue) :
                new ObjectParameter("cue", typeof(string));
    
            var iddParameter = idd.HasValue ?
                new ObjectParameter("idd", idd) :
                new ObjectParameter("idd", typeof(int));
    
            var dineroParameter = dinero.HasValue ?
                new ObjectParameter("dinero", dinero) :
                new ObjectParameter("dinero", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("prestamosss", cueParameter, iddParameter, dineroParameter);
        }
    
        public virtual int ingresos(string cue, Nullable<int> dinero)
        {
            var cueParameter = cue != null ?
                new ObjectParameter("cue", cue) :
                new ObjectParameter("cue", typeof(string));
    
            var dineroParameter = dinero.HasValue ?
                new ObjectParameter("dinero", dinero) :
                new ObjectParameter("dinero", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ingresos", cueParameter, dineroParameter);
        }
    
        public virtual int avance(string cue, Nullable<int> dinero)
        {
            var cueParameter = cue != null ?
                new ObjectParameter("cue", cue) :
                new ObjectParameter("cue", typeof(string));
    
            var dineroParameter = dinero.HasValue ?
                new ObjectParameter("dinero", dinero) :
                new ObjectParameter("dinero", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("avance", cueParameter, dineroParameter);
        }
    
        public virtual int ingresosN(string cue, Nullable<int> dinero)
        {
            var cueParameter = cue != null ?
                new ObjectParameter("cue", cue) :
                new ObjectParameter("cue", typeof(string));
    
            var dineroParameter = dinero.HasValue ?
                new ObjectParameter("dinero", dinero) :
                new ObjectParameter("dinero", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ingresosN", cueParameter, dineroParameter);
        }
    
        public virtual int ingresosP(string cue, Nullable<int> dinero)
        {
            var cueParameter = cue != null ?
                new ObjectParameter("cue", cue) :
                new ObjectParameter("cue", typeof(string));
    
            var dineroParameter = dinero.HasValue ?
                new ObjectParameter("dinero", dinero) :
                new ObjectParameter("dinero", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ingresosP", cueParameter, dineroParameter);
        }
    
        public virtual int retirosss(string cue, Nullable<int> dinero)
        {
            var cueParameter = cue != null ?
                new ObjectParameter("cue", cue) :
                new ObjectParameter("cue", typeof(string));
    
            var dineroParameter = dinero.HasValue ?
                new ObjectParameter("dinero", dinero) :
                new ObjectParameter("dinero", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("retirosss", cueParameter, dineroParameter);
        }
    
        public virtual int avances(string cue, Nullable<int> dinero)
        {
            var cueParameter = cue != null ?
                new ObjectParameter("cue", cue) :
                new ObjectParameter("cue", typeof(string));
    
            var dineroParameter = dinero.HasValue ?
                new ObjectParameter("dinero", dinero) :
                new ObjectParameter("dinero", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("avances", cueParameter, dineroParameter);
        }
    
        public virtual int ingresosNN(string cue, Nullable<int> dinero)
        {
            var cueParameter = cue != null ?
                new ObjectParameter("cue", cue) :
                new ObjectParameter("cue", typeof(string));
    
            var dineroParameter = dinero.HasValue ?
                new ObjectParameter("dinero", dinero) :
                new ObjectParameter("dinero", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ingresosNN", cueParameter, dineroParameter);
        }
    
        public virtual int ingresosPP(string cue, Nullable<int> dinero)
        {
            var cueParameter = cue != null ?
                new ObjectParameter("cue", cue) :
                new ObjectParameter("cue", typeof(string));
    
            var dineroParameter = dinero.HasValue ?
                new ObjectParameter("dinero", dinero) :
                new ObjectParameter("dinero", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ingresosPP", cueParameter, dineroParameter);
        }
    
        public virtual int retirossse(string cue, Nullable<int> dinero)
        {
            var cueParameter = cue != null ?
                new ObjectParameter("cue", cue) :
                new ObjectParameter("cue", typeof(string));
    
            var dineroParameter = dinero.HasValue ?
                new ObjectParameter("dinero", dinero) :
                new ObjectParameter("dinero", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("retirossse", cueParameter, dineroParameter);
        }
    }
}
