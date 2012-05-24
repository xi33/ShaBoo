using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShaBoo.Domain.Services;
using ShaBoo.Web.Infrastructure;

namespace ShaBoo.Web.Controllers
{
    using System.IO;

    using ShaBoo.Web.ViewModels;

    public class HomeController : BaseController
    {
        private IBLLService _service;
        public HomeController(IBLLService service)
        {
            _service = service;
        }

        public ActionResult Index()
        {
            var model = new IndexViewModel();
            model.MainCategories = _service.ClassService.GetFstClasses();
            model.SubCategories = _service.ClassService.GetSndClasses();
            model.CategoryWithDocumentses = new List<IndexViewModel.CategoryWithDocuments>();
            foreach (var main in model.MainCategories)
            {
                var m = main;
                var documents = _service.DocumentService.GetDocuments()
                    .Where(_ => _.FstClassID == m.ID).Take(8);
                model.CategoryWithDocumentses.Add(new IndexViewModel.CategoryWithDocuments
                {
                    MainCategory = main,
                    Documents = documents
                });
            }
            model.Boards = _service.BoardService.ListAllBoard();
            return View(model);
        }

        public ActionResult Board(int id)
        {
            var board = _service.BoardService.ListAllBoard().Where(_ => _.ID == id).FirstOrDefault();
            var model = new BoardViewModel
            {
                Title = board.Title, 
                Content = board.Content,
                PostedOn = board.PostedOn
            };

            return View(model);
        }

    }
}
