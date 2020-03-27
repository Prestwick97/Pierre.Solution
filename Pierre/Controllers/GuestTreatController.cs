// using Microsoft.AspNetCore.Mvc;
// using System.Collections.Generic;
// using System.Linq;
// using Microsoft.EntityFrameworkCore;
// using Microsoft.AspNetCore.Authorization;
// using Microsoft.AspNetCore.Identity;
// using System.Threading.Tasks;
// using System.Security.Claims;
// using Pierre.Models;

// namespace Pierre.Controllers
// {
//   public class GuestTreatController : Controller
//   {
//     public TreatsController(PierreContext db)
//     {
//       _db = db;
//     }

//     public ActionResult Index()
//     {
//       List<Treat> model = _db.Treats.ToList();
//       return View(model);
//     }

//     public ActionResult Create()
//     {
//       return View();
//     }
//   }
// }