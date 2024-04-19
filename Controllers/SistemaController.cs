using Banco_Nubank.ApplicationDBContext;
using Banco_Nubank.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Mvc;

namespace Banco_Nubank.Controllers
{
    public class SistemaController : Controller
    {
        private BaseConfiguration db = new BaseConfiguration();

        public Clientes Cliente { get; private set; }

        public ActionResult Index() //visualiza as informações
        {
            return View(db.Clientes.ToList());
        }

        public ActionResult Create()//criar as informações
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Create(Clientes Cliente)
        {
            if (ModelState.IsValid)
            {
                db.Clientes.Add(Cliente);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(Cliente);
        }
        //=====================================================================
        public ActionResult Edit(int? id)//Editar as informações
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Clientes Clientes = db.Clientes.Find(id);
            if (Clientes == null)
            {
                return HttpNotFound();
            }
            return View(Clientes);
        }
        //´POST: SISTEMA/EDIT/5
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Edit(Clientes Cliente)
        {
            if (ModelState.IsValid)
            {
                db.Entry(Cliente).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(Cliente);
        }
        //=====================================================================
        public ActionResult Delete(int? id)
        {
            Clientes Cliente = db.Clientes.Find(id);
            db.Clientes.Remove(Cliente);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        //=====================================================================
        public ActionResult Details(int? id) // detalhes
        {
            return View(db.Clientes.Find(id));
        }
      
        
        }
    }
  
    

