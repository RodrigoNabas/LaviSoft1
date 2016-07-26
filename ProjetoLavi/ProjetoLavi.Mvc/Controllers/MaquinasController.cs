using AutoMapper;
using ProjetoLavi.Aplicacao.Interface;
using ProjetoLavi.Dominio.Entities.Maquinas;
using ProjetoLavi.Mvc.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoLavi.Mvc.Controllers
{
    public class MaquinasController : Controller
    {
        private readonly IMaquinaAppService _maquinaApp;

        public MaquinasController(IMaquinaAppService maquinaApp)
        {
            _maquinaApp = maquinaApp;
        }

        // GET: Clientes
        public ActionResult Index()
        {
            var maquinaModel = Mapper.Map<IEnumerable<Maquina>, IEnumerable<MaquinaModel>>(_maquinaApp.GetAll());
            return View(maquinaModel);
        }

        // GET: Clientes/Details/5
        public ActionResult Details(int id)
        {
            var maquina= _maquinaApp.GetById(id);
            var maquinaModel = Mapper.Map<Maquina, MaquinaModel>(maquina);

            return View(maquinaModel);
        }

        // GET: Clientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create
        [HttpPost]
        public ActionResult Create(MaquinaModel maquina)
        {
            if (!ModelState.IsValid) return View(maquina);

            var maquinaDomain = Mapper.Map<MaquinaModel, Maquina>(maquina);
            _maquinaApp.Add(maquinaDomain);

            return RedirectToAction("Index");
        }

        // GET: Clientes/Edit/5
        public ActionResult Edit(int id)
        {
            var maquina = _maquinaApp.GetById(id);
            var maquinaViewModel = Mapper.Map<Maquina, MaquinaModel>(maquina);

            return View(maquinaViewModel);
        }

        // POST: Clientes/Edit/5
        [HttpPost]
        public ActionResult Edit(MaquinaModel maquina)
        {
            if (!ModelState.IsValid) return View(maquina);
            var maquinaDomain = Mapper.Map<MaquinaModel, Maquina>(maquina);
            _maquinaApp.Update(maquinaDomain);

            return RedirectToAction("Index");
        }

        // GET: Clientes/Delete/5
        public ActionResult Delete(int id)
        {
            var maquina = _maquinaApp.GetById(id);
            var maquinaModel = Mapper.Map<Maquina, MaquinaModel>(maquina);

            return View(maquinaModel);
        }

        // POST: Clientes/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var maquina = _maquinaApp.GetById(id);
            _maquinaApp.Remove(maquina);

            return RedirectToAction("Index");
        }
    }
}