using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SistemaAsp.Models;
using SistemaAsp.Controllers;
using SistemaAsp.Models.ViewModels;

namespace SistemaAsp.Controllers
{
    public class EmpledosController : Controller
    {
        // GET: Empledos
        public ActionResult Index()

        {
            List<ListTablaEmpleados> lst;
            using (dbempleadosEntities1 db = new dbempleadosEntities1())
            {
         
                lst = (from d in db.empleados
                          select new ListTablaEmpleados
                          {
                            Id =d.id,
                            nombre = d.nombre,
                             edad = (int)d.edad,
                             telefono = (int)d.telefono,
                             direccion = d.direccion,
                             empresa = d.empresa,
                             departamento = d.empresa




                          }).ToList();
            }

            return View(lst);
        }
        public ActionResult Nuevo()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Nuevo(EmpleadosViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (dbempleadosEntities1 db = new dbempleadosEntities1())
                    {
                        var oTabla = new empleado();
                        oTabla.nombre = model.nombre;
                        oTabla.edad = model.edad;

                        oTabla.telefono = model.telefono;
                        oTabla.direccion = model.direccion;
                        oTabla.empresa = model.empresa;
                        oTabla.departamento = model.departamento;
                        db.empleados.Add(oTabla);
                        db.SaveChanges();
                    }

                    return Redirect("~/Empledos/");
                }

                return View(model);


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public ActionResult Editar(int Id)
        {
            EmpleadosViewModel model = new EmpleadosViewModel();
            using (dbempleadosEntities1 db = new dbempleadosEntities1())
            {
             
                var oTabla = db.empleados.Find(Id);
                model.Id = oTabla.id;
                model.nombre = oTabla.nombre;
                model.edad = (int)oTabla.edad;
                model.telefono = (int)oTabla.telefono;
                model.direccion = oTabla.direccion;
                model.empresa = oTabla.empresa;
                model.departamento = oTabla.departamento;
               
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult Editar(EmpleadosViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (dbempleadosEntities1 db = new dbempleadosEntities1())
                    {
                        var oTabla = db.empleados.Find(model.Id);
                        oTabla.nombre = model.nombre;
                        oTabla.edad = model.edad;

                        oTabla.telefono = model.telefono;
                        oTabla.direccion = model.direccion;
                        oTabla.empresa = model.empresa;
                        oTabla.departamento = model.departamento;

                        db.Entry(oTabla).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }

                    return Redirect("~/Empledos/");
                }

                return View(model);


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpGet]
        public ActionResult Eliminar(int Id)
        {
            using (dbempleadosEntities1 db = new dbempleadosEntities1())
            {

                var oTabla = db.empleados.Find(Id);
                db.empleados.Remove(oTabla);
                db.SaveChanges();
            }
            return Redirect("~/Empledos/");
        }

    }
}