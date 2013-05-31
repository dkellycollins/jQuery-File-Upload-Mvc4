using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using jQuery_File_Upload_Mvc4.Models;

namespace jQuery_File_Upload_Mvc4.Controllers
{
    public class UploadController : Controller
    {

        public string UploadDirectory
        {
            get
            {
                var server = System.Web.HttpContext.Current.Server;
                string uploadDirectory = server.MapPath("~/App_Data/Uploads");
                if (!Directory.Exists(uploadDirectory))
                    Directory.CreateDirectory(uploadDirectory);
                return uploadDirectory;
            }
        }

        [HttpGet]
        public ActionResult BasicUpload()
        {
            return View();
        }]

        [HttpPost]
        public ActionResult BasicUpload(BasicFileUpload file)
        {
            try
            {
                string path = Path.Combine(UploadDirectory, file.FileName);
                FileStream fileStream = System.IO.File.Create(path);
                file.InputStream.CopyTo(fileStream);
                fileStream.Close();
                return new HttpStatusCodeResult(200);
            }
            catch (Exception e)
            {
                Debug.Write(e.Message + "\n" + e.StackTrace);
                return new HttpStatusCodeResult(500);
            }
        }

        [HttpGet]
        public ActionResult BasicPlusUpload()
        {
            return View();
        }

        [HttpPost]
        public ActionResult BasicPlusUpload(BasicPlusFileUpload file)
        {
            try
            {
                string path = Path.Combine(UploadDirectory, file.FileName);
                FileStream fileStream = System.IO.File.Create(path);
                file.InputStream.CopyTo(fileStream);
                fileStream.Close();
                return new HttpStatusCodeResult(200);
            }
            catch (Exception e)
            {
                Debug.Write(e.Message + "\n" + e.StackTrace);
                return new HttpStatusCodeResult(500);
            }
        }

        [HttpGet]
        public ActionResult BasicPlusUIUpload()
        {
            return View();
        }

        [HttpPost]
        public ActionResult BasicPlusUIUpload(BasicPlusUIFileUpload file)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public ActionResult AngularJSUpload()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AngularJSUpload(AngularJSFileUpload file)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public ActionResult ChunkedUpload()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ChunkedUpload(ChunkedFileUplaod file)
        {
            throw new NotImplementedException();
        }
    }
}
