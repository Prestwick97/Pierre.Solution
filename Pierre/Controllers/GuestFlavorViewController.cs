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
//   public class GuestFlavorController : Controller
//   {
//     private readonly PierreContext _db;

//     public TreatsController(PierreContext db)
//     {
//       _db = db;
//     }

//     public ActionResult Index()
//     {
//       List<Treat> model = _db.Flavors.ToList();
//       return View(model);
//     }
//   }
// }