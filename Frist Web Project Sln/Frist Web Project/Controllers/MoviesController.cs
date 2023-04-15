using Microsoft.AspNetCore.Mvc;

namespace Frist_Web_Project.Controllers
{
    public class MoviesController : Controller
    {
        //Action Has to be Public non static Func
        #region Actions

        //public string GetMovie(int id) => $"Movie Id is {id}";

        //public string Index() => $"Index"; 
        #endregion

        #region Return Type Of Actions
        /* 
         *  Action Result                Helper Method
         *  ------------------------------------------
         *  ViewResult                  View
         *  PartialViewResult           PartialView
         *  RedirectResult              Redirect
         *  RedirectToRouteResult       RedirectToAction or RedirectToRoute
         *  ContentResult               Content
         *  JsonResult                  Json
         *  JavaScriptResult            JavaScript
         *  HttpStatusCodeResult        (None)
         *  HttpUnauthorizedResult      (None)
         *  HttpNotFoundResult          HttpNotFound
         *  FileResult                  File
         *  EmptyResult                 (None)
         */

        //public IActionResult Hamada()
        //{
        //    return Content("Hamada","text/html");
        //    //return Content("Hamada", "object/pdf");
        //}
        //public IActionResult RedirectHamada()
        //{
        //    //return RedirectToAction(Takes Action Name);
        //    return RedirectToAction("Hamada");
        //    //return RedirectToRoute(Takes Route Name);
        //    //return Redirect(Takes static Url);
        //}
        #endregion

        #region Action Patameters Binding
        public IActionResult GetMovie(int Id, string Name, Employee employee)
        {
            //ContentResult result = new ContentResult();
            //result.Content = $"Movie With Id: {Id}";
            //return result;

            //Four Way to send data to an Action Parameter 1- URL (Segment) "https://localhost:44376/movies/GetMovie/10" 
            //                                             2- String Query  "https://localhost:44376/movies/GetMovie/10?id=22"
            //                                             3- Throw Html Form Can Be Tested Throw PostMan 
            //                                             4- Thtow A File .Txt ...etc Not that Common

            /// https://localhost:44376/movies/GetMovie?id=132&name=Ahmed&employee.name=hamada&employee.id=3 Example
            /// example  if the param is an array send the value like the following
            /// https://localhost:44376/movies/GetMovie?arr[0]=1

            return Content($"Movie With Id: {Id} ||| Movue Name: {Name} ||| Emp ID = {employee.Id} ||| Emp Name = {employee.Name}");
        }
        #endregion
    }
}
