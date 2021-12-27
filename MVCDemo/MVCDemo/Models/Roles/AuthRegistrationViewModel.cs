using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MVCDemo.Models.Roles
{
    public class AuthRegistrationViewModel
    {
        public List<SelectListItem> Roles { get; set; }

        public string SelectedRole { get; set; }
    }
}
