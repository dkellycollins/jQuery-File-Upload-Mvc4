using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace jQuery_File_Upload_Mvc4.Models
{
    [ModelBinder(typeof(ChunkedFileUploadBinder))]
    public class ChunkedFileUpload
    {
        public class ChunkedFileUploadBinder : IModelBinder
        {
            public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
            {
                throw new NotImplementedException();
            }
        }
    }
}