using MonsterHunterTool.Models.Entity;
using MonsterHunterTool.Models.Info;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonsterHunterTool.Models.ViewModel
{
	public class LotResultViewModel :BaseViewModel
	{
		public QuestEntity QuestEntity { get; set; }

		public IEnumerable<PlayerInfo> PlayerInfoList { get; set; }
	}
}