using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace BookStore.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            HttpRequest request = HttpContext.Request;

            List<String> list = new List<String>();
            list.Add("first value");
            list.Add("second value");
            list.Add("third value");
            list.Add("four value");
            list.Add("5 value");



            int[] arr = new int[5] { 1, 2, 3, 4, 5 };
            int[] arr2 = { 1, 2, 3, 4, 5 };

            ViewData["Title1"] = "Hi shark";
        }
    }
}
