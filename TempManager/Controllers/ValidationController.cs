using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System;
using TempManager.Models;
// Author: Firaol Baneta
//Date: 3/3/2024
namespace Ch11Ex1TempManager.Controllers
{
    public class ValidationController : Controller
    {
        private readonly TempManagerContext _context;

        public ValidationController(TempManagerContext context)
        {
            _context = context;
        }

        public JsonResult CheckDate(string date)
        {
            if (DateTime.TryParse(date, out DateTime parsedDate))
            {
                var existingTemp = _context.Temps.FirstOrDefault(t => t.Date == parsedDate);

                if (existingTemp == null)
                {
                    return Json(true);
                }
            }

            return Json("Date already exists in the database.");
        }
    }
}
