using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BrioDevExercise.Controllers
{
    public class BrioController : Controller
    {
        // GET: Brio
        public ActionResult Index(string longitude, string latitude, string address)
        {
            try
            {
                if (!string.IsNullOrEmpty(longitude) && !string.IsNullOrEmpty(latitude))
                {

                    var la = Convert.ToDouble(latitude);
                    var lo = Convert.ToDouble(longitude);
                    return View(Helpers.DarkSkyGet.SyncGetLL(la, lo));
                }
                    
                else
                    return View(Helpers.DarkSkyGet.SyncGet());
            }
            catch
            {
                return View(Helpers.DarkSkyGet.SyncGet());
            }
        }

        //public ActionResult IndexPartial(long? longitude, long? latitude, string address)
        //{
        //    return PartialView(Helpers.DarkSkyGet.SyncGetLL((long)latitude, (long)longitude));
        //}
    }
}