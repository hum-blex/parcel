using Microsoft.AspNetCore.Mvc;
using parcel.Data;
using parcel.Models;

namespace parcel.Controllers
{
	public class MailController : Controller
	{
		private readonly ApplicationDbContext _db;

        public MailController(ApplicationDbContext db)
        {
			_db = db;
        }
        public IActionResult Index()
		{
			IEnumerable<mail> objMailList = _db.Mails;
			return View(objMailList);
		}

		//Get
		public IActionResult Create()
		{
			return View();
		}
		//POST
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Create(mail obj)
		{
			_db.Mails.Add(obj);
			_db.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}
