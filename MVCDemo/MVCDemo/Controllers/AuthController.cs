using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVCDemo.AppData;
using MVCDemo.Models;
using MVCDemo.Models.Roles;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MVCDemo.Controllers
{
    public class AuthController : Controller
    {
        private readonly Database _db;

        public AuthController(Database db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var model = _db.GetRoles();

            var roles = model.Select(x => new SelectListItem
            {
                Text = x.RoleName,
                Value = Convert.ToString(x.RoleId)
            }).ToList();

            var regViewodel = new AuthRegistrationViewModel
            {
                Roles = roles
            };
            return View(regViewodel);
        }
    }
}
