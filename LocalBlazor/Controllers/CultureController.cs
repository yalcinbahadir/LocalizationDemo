using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalBlazor.Controllers
{
    [Route("[controller]/[action]")]
    public class CultureController : Controller
    {
        public IActionResult SetCulture(string culture, string redirectUri)//selected culture, form of UI according to this culture
        {
            //This is selected culture
            if (culture!= null)
            {
                HttpContext.Response.Cookies.Append(
                    CookieRequestCultureProvider.DefaultCookieName, 
                    CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)));
            }
            //Go to related page/UI
            return LocalRedirect(redirectUri);
        }
    }
}
