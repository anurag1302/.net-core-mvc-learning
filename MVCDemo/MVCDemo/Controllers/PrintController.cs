using Microsoft.AspNetCore.Mvc;
using MVCDemo.AppData;

namespace MVCDemo.Controllers
{
    public class PrintController : Controller
    {
        private readonly Database _db;

        public PrintController(Database db)
        {
            _db = db;
        }
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

        public IActionResult GetDatabyId(int id)
        {
            var filteredData = Data.GetFilteredDocumentTypes(id);

            return View("UpdateData",filteredData);
        }

        public IActionResult Persons()
        {
            var model = _db.GetPersonsData();

            return View(model);
        }
    }
}
