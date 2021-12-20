using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace MVCDemo.Attributes
{
    public class ValidateAjaxAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var modelState = context.ModelState;

            if (!modelState.IsValid)
            {

                //var result = modelState.Keys
                //    .Where(x => modelState[x].Errors.Count > 0).Select(y => new
                //    {
                //        Key = y,
                //        Errors = modelState[y].Errors.Select(y => y.ErrorMessage).ToArray()

                //    });
                var result = modelState.Keys
                    .Where(x => modelState[x].Errors.Count > 0).Select(y => new ErrorMessage
                    {
                        Key = y,
                        Errors = modelState[y].Errors.Select(y => y.ErrorMessage).ToArray()

                    }).ToList();

                //var msg = new ErrorMessage();
                //var list = new List<ErrorMessage>();
                //foreach(var item in modelState.Keys)
                //{
                //    foreach(var e in modelState[item].Errors)
                //    {
                //        msg.Key = item;
                //        msg.Errors = modelState[item].Errors.Select(x => x.ErrorMessage).ToArray();
                //        list.Add(msg);
                //    }
                //}
                context.Result = new JsonResult(result);
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;

            }

        }

        public class ErrorMessage
        {
            public string Key { get; set; }
            public string[] Errors { get; set; }
        }
    }
}
