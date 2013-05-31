using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Mvc;

namespace jQuery_File_Upload_Mvc4.Models
{
    [ModelBinder(typeof(BasicFileUploadBinder))]
    public class BasicFileUpload
    {
        public string FileName { get; set; }
        public Stream InputStream { get; set; }

        public class BasicFileUploadBinder : IModelBinder
        {
            public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
            {
                var request = controllerContext.RequestContext.HttpContext.Request;

                string fileName = request.Files[0].FileName;
                Stream inputStream = request.Files[0].InputStream;

                return new BasicFileUpload()
                {
                    FileName = fileName,
                    InputStream = inputStream
                };
            }
        }
    }
}