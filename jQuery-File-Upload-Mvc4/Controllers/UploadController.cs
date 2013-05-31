using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using jQuery_File_Upload_Mvc4.Models;

namespace jQuery_File_Upload_Mvc4.Controllers
{
    public class UploadController : Controller
    {

        [HttpGet]
        public ActionResult BasicUpload()
        {
            return View();
        }

        [HttpPost]
        public ActionResult BasicUpload(BasicFileUpload file)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public ActionResult BasicPlusUpload()
        {
            return View();
        }

        [HttpPost]
        public ActionResult BasicPlusUpload(BasicPlusFileUpload file)
        {
            throw new NotImplementedException();
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
    }
}
