using AutoMapper;
using ProjetoLavi.Aplicacao.Interface;
using ProjetoLavi.Dados.Repositories;
using ProjetoLavi.Dominio.Entities.Fornecedor;
using ProjetoLavi.Mvc.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoLavi.Mvc.Controllers
{
    public class FornecedorController : Controller
    {
        private readonly IFornecedorAppService _fornecedorApp;

        public FornecedorController(IFornecedorAppService fornecedorApp)
        {
            _fornecedorApp = fornecedorApp;
        }


        // GET: Fornecedor
        public ActionResult Index()
        {
            var fornecedorViewModel = Mapper.Map<IEnumerable<Fornecedor>, IEnumerable<FornecedorModel>>(_fornecedorApp.GetAll());
            return View(fornecedorViewModel);
        }

        // GET: Fornecedor/Details/5
        public ActionResult Details(int id)
        {
            var fornecedor = _fornecedorApp.GetById(id);
            var fornecedorVireModel = Mapper.Map<Fornecedor, FornecedorModel>(fornecedor);

            return View(fornecedorVireModel);
        }

        // GET: Fornecedor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Fornecedor/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FornecedorModel fornecedor)
        {
            if(ModelState.IsValid)
            {
                var fornecedorDomain = Mapper.Map<FornecedorModel, Fornecedor>(fornecedor);
                _fornecedorApp.Add(fornecedorDomain);

                return RedirectToAction("Index");
            }

            return View(fornecedor);
        }

        // GET: Fornecedor/Edit/5
        public ActionResult Edit(int id)
        {
            var fornecedor = _fornecedorApp.GetById(id);
            var fornecedorViewModel = Mapper.Map<Fornecedor, FornecedorModel>(fornecedor);

            return View(fornecedorViewModel);
        }

        // POST: Fornecedor/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(FornecedorModel fornecedor)
        {
            if(ModelState.IsValid)
            {
                var fornecedorDomain = Mapper.Map<FornecedorModel, Fornecedor>(fornecedor);
                _fornecedorApp.Update(fornecedorDomain);

                return RedirectToAction("Index");
            }

            return View(fornecedor);
        }

        // GET: Fornecedor/Delete/5
        public ActionResult Delete(int id)
        {
            var fornecedor = _fornecedorApp.GetById(id);
            var fornecedorViewModel = Mapper.Map<Fornecedor, FornecedorModel>(fornecedor);

            return View(fornecedorViewModel);
        }

        // POST: Fornecedor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var fornecedor = _fornecedorApp.GetById(id);
            _fornecedorApp.Remove(fornecedor);

            return RedirectToAction("Index");
        }
    }
}
