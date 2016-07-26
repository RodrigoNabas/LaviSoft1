using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using ProjetoLavi.Aplicacao.Interface;
using ProjetoLavi.Dominio.Entities.Cliente;
using ProjetoLavi.Mvc.ViewModels;

namespace ProjetoLavi.Mvc.Controllers
{
    public class ClientesController : Controller
    {
        private readonly IClienteAppService _clienteApp;

        public ClientesController(IClienteAppService clienteApp)
        {
            _clienteApp = clienteApp;
        }

        // GET: Clientes
        public ActionResult Index()
        {
            var clienteModel = Mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteModel>>(_clienteApp.GetAll());
            return View(clienteModel);
        }

        // GET: Clientes/Details/5
        public ActionResult Details(int id)
        {
            var cliente = _clienteApp.GetById(id);
            var clienteModel = Mapper.Map<Cliente, ClienteModel>(cliente);

            return View(clienteModel);
        }

        // GET: Clientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create
        [HttpPost]
        public ActionResult Create(ClienteModel cliente)
        {
            if (!ModelState.IsValid) return View(cliente);

            var clienteDomain = Mapper.Map<ClienteModel, Cliente>(cliente);
            _clienteApp.Add(clienteDomain);

            return RedirectToAction("Index");
        }

        // GET: Clientes/Edit/5
        public ActionResult Edit(int id)
        {
            var cliente = _clienteApp.GetById(id);
            var clienteViewModel = Mapper.Map<Cliente, ClienteModel>(cliente);

            return View(clienteViewModel);
        }

        // POST: Clientes/Edit/5
        [HttpPost]
        public ActionResult Edit(ClienteModel cliente)
        {
            if (!ModelState.IsValid) return View(cliente);
            var clienteDomain = Mapper.Map<ClienteModel, Cliente>(cliente);
            _clienteApp.Update(clienteDomain);

            return RedirectToAction("Index");
        }

        // GET: Clientes/Delete/5
        public ActionResult Delete(int id)
        {
            var cliente = _clienteApp.GetById(id);
            var clienteModel = Mapper.Map<Cliente, ClienteModel>(cliente);

            return View(clienteModel);
        }

        // POST: Clientes/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var cliente = _clienteApp.GetById(id);
            _clienteApp.Remove(cliente);

            return RedirectToAction("Index");
        }
    }
}
