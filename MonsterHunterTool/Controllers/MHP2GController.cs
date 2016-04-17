using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MonsterHunterTool.Services;
using MonsterHunterTool.Models.ViewModel;

namespace MonsterHunterTool.Controllers
{
    public class MHP2GController : Controller
    {
		private MHP2GService _service = null;

		public MHP2GController()
		{
			_service = new MHP2GService();
		}

		[HttpGet]
		public ActionResult QuestLot()
		{
			QuestLotViewModel viewModel = _service.GetQuestLotViewModel();

			return View(viewModel);
		}

		[HttpPost]
		public ActionResult QuestLot(QuestLotViewModel viewModel)
		{
			viewModel.Title = "抽選結果";
			return View(viewModel);
		}

      
    }
}