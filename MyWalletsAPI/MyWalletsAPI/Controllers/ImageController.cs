using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace MyWalletsAPI.Controllers
{
    public class ImageController : ApiController
    {
        public void upload()
        {
            HttpContext.Current.Server.MapPath("");
        }
    }
}
