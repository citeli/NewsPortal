using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Web.Mvc;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces.Services;
using Domain.Services;
using NewsPortalMVC.ViewModels;

namespace NewsPortalMVC.Controllers
{
    public class NoticiasController : Controller
    {
        private readonly INoticiaAppService _noticiaApp;
        private readonly IUsuarioAppService _usuarioApp;

        public NoticiasController(INoticiaAppService noticiaApp, IUsuarioAppService usuarioApp)
        {
            _noticiaApp = noticiaApp;
            _usuarioApp = usuarioApp;
        }

        // GET: Noticias
        public ActionResult Index()
        {
            var noticiaViewModel = Mapper.Map<IEnumerable<Noticia>, IEnumerable<NoticiaViewModel>>(_noticiaApp.GetAll());
            return View(noticiaViewModel);
        }

        // GET: Noticias/Details/5
        public ActionResult Details(int id)
        {
            var noticia = _noticiaApp.GetById(id);
            var noticiaViewModel = Mapper.Map<Noticia, NoticiaViewModel>(noticia);

            return View(noticiaViewModel);
        }

        // GET: Noticias/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Noticias/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(NoticiaViewModel noticia)
        {
            if (ModelState.IsValid)
            {
                var noticiaDomain = Mapper.Map<NoticiaViewModel, Noticia>(noticia);
                var client = new NoticiaServiceWCF.NoticiaServiceClient();
                client.Open();
                try
                {
                    client.GravarNoticia(noticiaDomain);
                }
                catch(FaultException<NoticiaService>)
                {
                    
                }
                client.Close();
                //_noticiaApp.Add(noticiaDomain);

                return RedirectToAction("Index");
            }

            return View(noticia);
        }

        // GET: Noticias/Edit/5
        public ActionResult Edit(int id)
        {
            var noticia = _noticiaApp.GetById(id);
            var noticiaViewModel = Mapper.Map<Noticia, NoticiaViewModel>(noticia);

            return View(noticiaViewModel);
        }

        // POST: Noticias/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(NoticiaViewModel noticia)
        {
            if (ModelState.IsValid)
            {
                var noticiaDomain = Mapper.Map<NoticiaViewModel, Noticia>(noticia);
                _noticiaApp.Update(noticiaDomain);

                return RedirectToAction("Index");
            }

            return View(noticia);
        }

        // GET: Noticias/Delete/5
        public ActionResult Delete(int id)
        {
            var noticia = _noticiaApp.GetById(id);
            var noticiaViewModel = Mapper.Map<Noticia, NoticiaViewModel>(noticia);

            return View(noticiaViewModel);
        }

        // POST: Noticias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var noticia = _noticiaApp.GetById(id);
            _noticiaApp.Remove(noticia);

            return RedirectToAction("Index");
        }
    }
}
