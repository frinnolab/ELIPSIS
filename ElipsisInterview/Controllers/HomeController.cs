using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElipsisInterview.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Circular()
        {
            ViewBag.Message = "Circular Array";

            return View("About");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult GetCirculars(FormCollection form)
        {
            string[] arrayVals;
            int[] arrayVals_;
            
            
            int n,k,q;

            arrayVals = form["arrayValues"].Split(' ');
            arrayVals_ = Array.ConvertAll(arrayVals, int.Parse);




            n = arrayVals_.Length;
            k = n;
            q = 0;

            

            rotateArray(arrayVals_, 0, n - 1);

            var data = new { arrayVals_ };
            ViewBag.resultTxt = arrayVals_;
            return View("About");
        }

        public void rotateArray(int[] arr, int start,
                                        int end)
        {
            while (start < end)
            {
                int temp = arr[end];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }

    }
}