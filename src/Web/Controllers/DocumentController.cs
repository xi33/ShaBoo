using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShaBoo.Domain.Services;
using ShaBoo.Web.ViewModels;

namespace ShaBoo.Web.Controllers
{
    using ShaBoo.Services.Util;

    [Authorize(Roles = "User")]
    public class DocumentController : Controller
    {
        #region ctor
        private IBLLService _service;
        public DocumentController(IBLLService service)
        {
            _service = service;
        }
        #endregion

        /// <summary>
        /// 文件上传目录
        /// </summary>
        private string StorageRoot
        {
            get { return Path.Combine(System.Web.HttpContext.Current.Server.MapPath("~/Files/")); } //Path should! always end with '/'
        }

        public ActionResult Upload()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Upload(DocumentViewModels.UploadModel model)
        {
            string path = StorageRoot;
            string filePath = Path.Combine(path, model.FileName);
            var suffix = Path.GetExtension(filePath);
            var size = ((Int32)new System.IO.FileInfo(filePath).Length) / (1024 * 1024);
            _service.DocumentService.CreateNewUploadedDocument(
                model.Title, model.FstClass, model.SndClass, model.TrdClass,
                model.Tags, model.Intro,
                filePath, size, suffix,
                0, 0, DateTime.UtcNow, User.Identity.Name);
            return Content("谢谢，上传成功", "text/html");
        }


        /// <summary>
        /// 上传文件
        /// </summary>
        /// <param name="qqfile"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult FileUpload(string qqfile)
        {
            var file = string.Empty;

            try
            {
                var stream = Request.InputStream;
                if (String.IsNullOrEmpty(Request["qqfile"]))
                {
                    // IE
                    HttpPostedFileBase postedFile = Request.Files[0];
                    stream = postedFile.InputStream;
                    file = Path.Combine(StorageRoot, Path.GetFileName(postedFile.FileName));
                }
                else
                {
                    //Webkit, Mozilla
                    file = Path.Combine(StorageRoot, qqfile);
                }

                var buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);
                System.IO.File.WriteAllBytes(file, buffer);
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message }, "application/json");
            }

            return Json(new { success = true }, "text/html");
        }

        public ActionResult Single(int id)
        {
            var document = _service.DocumentService.GetDocuments().Where(_ => _.ID == id).FirstOrDefault();
            var model = new DocumentViewModels.DownloadModel
                {
                    ID = id,
                    Title = document.Title,
                    Downloads = document.Downloads,
                    Views = document.Views,
                    Suffix = document.Suffix,
                    Intro = document.Intro,
                    UploadedOn = document.UploadedOn,
                    User = document.Profile.UserName,
                    Size = document.Size
                };
            return View(model);
        }

        public ActionResult Download(int id)
        {

            var document = _service.DocumentService.GetDocument(id);

            if (document != null)
            {
                var path = document.Path;
                string filename = document.Title + Path.GetExtension(path);
                string contentType = RegistryMimeTypeLookup.GetMimeType(path);
                var file = new FileInfo(path);
                if (file.Exists)
                {
                    return File(document.Path, contentType, filename);
                }
            }
            return null;
        }

        #region Ajax获得三级分类
        [HttpPost]
        public ActionResult GetFstClasses()
        {
            try
            {
                var fstClassList = _service.ClassService.GetFstClasses();

                var returndata = from fstClass in fstClassList
                                 select new
                                 {
                                     ID = fstClass.ID,
                                     Name = fstClass.Name
                                 };

                return Json(new { ok = true, data = returndata, message = "ok" });
            }
            catch (Exception ex)
            {
                return Json(new { ok = false, message = ex.Message });
            }
        }

        [HttpPost]
        public ActionResult GetSndClasses(int id)
        {
            try
            {
                var sndClassList = _service.ClassService.GetSndClasses();

                var returndata = from sndClass in sndClassList
                                 where sndClass.FstClassID == id
                                 select new
                                 {
                                     ID = sndClass.ID,
                                     Name = sndClass.Name
                                 };

                return Json(new { ok = true, data = returndata, message = "ok" });
            }
            catch (Exception ex)
            {
                return Json(new { ok = false, message = ex.Message });
            }
        }

        [HttpPost]
        public ActionResult GetTrdClasses(int id)
        {
            try
            {
                var trdClassList = _service.ClassService.GetTrdClasses();

                var returndata = from trdClass in trdClassList
                                 where trdClass.SndClassID == id
                                 select new
                                 {
                                     ID = trdClass.ID,
                                     Name = trdClass.Name
                                 };

                return Json(new { ok = true, data = returndata, message = "ok" });
            }
            catch (Exception ex)
            {
                return Json(new { ok = false, message = ex.Message });
            }
        }
        #endregion
    }
}
