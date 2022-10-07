using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace OrderManagement.Controllers
{
    public class SharedController : Controller
    {
        public ActionResult Language(int id)
        {
          
            Helper.Helper.CurrentCulture = id;
            if (!(Request.UrlReferrer == null))
            {
                return Redirect(Request.UrlReferrer.ToString());
            }

            return RedirectToRoute("/");
        }

        protected override IAsyncResult BeginExecute(RequestContext requestContext, AsyncCallback callback, object state)
        {
            Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture =
                Helper.Helper.Culture ?? new CultureInfo("en-US");
            return base.BeginExecute(requestContext, callback, state);
        }
    }
}