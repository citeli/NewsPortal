using System.Collections.Generic;
using System.ServiceModel;
using System.Web.Mvc;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Services;
using NewsPortalMVC.ViewModels;

namespace NewsPortalMVC.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly IUsuarioAppService _usuarioApp;

        public UsuariosController(IUsuarioAppService usuarioApp)
        {
            _usuarioApp = usuarioApp;
        }

        // GET: Usuarios
        public ActionResult Index()
        {
            var usuarioViewModel = Mapper.Map<IEnumerable<Usuario>, IEnumerable<UsuarioViewModel>>(_usuarioApp.GetAll());
            return View(usuarioViewModel);
        }

        // GET: Usuarios/Details/5
        public ActionResult Details(int id)
        {
            var usuario = _usuarioApp.GetById(id);
            var usuarioViewModel = Mapper.Map<Usuario, UsuarioViewModel>(usuario);

            return View(usuarioViewModel);
        }

        // GET: Usuarios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Usuarios/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UsuarioViewModel usuario)
        {
            if (ModelState.IsValid)
            {
                var usuarioDomain = Mapper.Map<UsuarioViewModel, Usuario>(usuario);
                var client = new UsuarioServiceWCF.UsuarioServiceClient();
                client.Open();
                try
                {
                    client.GravarUsuario(usuarioDomain);
                }
                catch (FaultException<UsuarioService>)
                {
                    
                }
                client.Close();
                //_usuarioApp.Add(usuarioDomain);

                return RedirectToAction("Index");
            }

            return View(usuario);
        }

        // GET: Usuarios/Edit/5
        public ActionResult Edit(int id)
        {
            var usuario = _usuarioApp.GetById(id);
            var usuarioViewModel = Mapper.Map<Usuario, UsuarioViewModel>(usuario);

            return View(usuarioViewModel);
        }

        // POST: Usuarios/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(UsuarioViewModel usuario)
        {
            if (ModelState.IsValid)
            {
                var usuarioDomain = Mapper.Map<UsuarioViewModel, Usuario>(usuario);
                _usuarioApp.Update(usuarioDomain);

                return RedirectToAction("Index");
            }

            return View(usuario);
        }

        // GET: Usuarios/Delete/5
        public ActionResult Delete(int id)
        {
            var usuario = _usuarioApp.GetById(id);
            var usuarioViewModel = Mapper.Map<Usuario, UsuarioViewModel>(usuario);

            return View(usuarioViewModel);
        }

        // POST: Usuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var usuario = _usuarioApp.GetById(id);
            _usuarioApp.Remove(usuario);

            return RedirectToAction("Index");
        }
    }
}
