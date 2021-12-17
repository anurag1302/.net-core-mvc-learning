using Microsoft.AspNetCore.Mvc;

namespace MVCDemo.Controllers
{
    public class PrintController : Controller
    {
        public IActionResult Index()
        {
            var modelData = Data.GetDocuments();
            return View(modelData);
        }

        public IActionResult GetDocumentDatabyId(int docId)
        {
            var filteredData = Data.GetFilteredDocumentTypes(docId);

            return PartialView("~/Views/Print/_DocumentTypesPartial.cshtml",filteredData);
        }
    }
}
