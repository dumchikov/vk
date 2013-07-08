using System;
using System.Web.Mvc;
using System.IO;

namespace VkService.Web.Controllers
{
    public class VkController : Controller
    {
        public void Index(string access_token, string expires_in, string user_id)
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tokens.txt");
            System.IO.File.WriteAllLines(path, new []
                {
                    "access_token: " + access_token, 
                    "expires_in: " + expires_in,
                    "user_id: " + user_id
                });
        }
    }
}
