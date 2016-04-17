using MonsterHunterTool.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MonsterHunterTool.Services
{
	public class MHP2GService
	{
		public QuestLotViewModel GetQuestLotViewModel()
		{
			var viewModel = new QuestLotViewModel();
			viewModel.Title = "MHP2G クエスト抽選";
			var playerNumList = new List<SelectListItem>();
			for (int i = 1; i <= 4; i++)
			{
				var item = new SelectListItem();
				item.Value = i.ToString();
				item.Text = i.ToString() + "人";
				playerNumList.Add(item);
			}
			viewModel.PlayerNumList = playerNumList;
			viewModel.PlayerNameList = new List<string>(4);

			return viewModel;
		}
	}
}