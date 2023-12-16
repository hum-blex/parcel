using Microsoft.AspNetCore.Mvc;
using Parcel1.DataAccess.Repository.IRepository;
using Parcel1.Models;


namespace parcel.Areas.Users.Controllers
{
	[Area("Users")]
	public class MailController : Controller
	{
		private readonly IUnitOfWork _unitOfWork;

		public MailController(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}
		public IActionResult Index()
		{
			IEnumerable<mail> objMailList = _unitOfWork.Mail.GetAll().ToList();
			return View(objMailList);
		}

		//GET
		public IActionResult Create()
		{
			return View();
		}

		//POST
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Create(mail obj)
		{
			if (ModelState.IsValid)
			{
				_unitOfWork.Mail.Add(obj);
				_unitOfWork.Save();
				TempData["success"] = "Mail sent";
				return RedirectToAction("Index");
			}
			return View();

		}

		//public IActionResult Delete(int? id)
		//{
		//	if (id == null || id ==0 ) 
		//	{
		//		return NotFound();
		//	}
		//	mail? mailFromdb = _mailRepo.Get(u=>u.Id == id);
		//	if (mailFromdb == null)
		//	{
		//		return NotFound();
		//	}
		//	return View(mailFromdb);
		//}
	}
}
