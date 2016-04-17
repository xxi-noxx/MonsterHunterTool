using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MonsterHunterTool.Models.ViewModel
{
	/// <summary>
	/// クエスト抽選画面用ViewModel
	/// </summary>
	public class QuestLotViewModel : BaseViewModel
	{
		/// <summary>
		/// プレイヤー人数表示用リスト
		/// </summary>
		public IEnumerable<SelectListItem> PlayerNumList { get; set; }

		public IEnumerable<string> PlayerNameList { get; set; }
	}
}