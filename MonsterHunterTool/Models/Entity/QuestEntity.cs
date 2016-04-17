using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonsterHunterTool.Models.Entity
{
	public class QuestEntity
	{
		/// <summary>
		/// クエストコード
		/// </summary>
		public int QuestCD { get; set; }
		/// <summary>
		/// クエスト名称
		/// </summary>
		public string QuestName { get; set; }
		/// <summary>
		/// クエスト種別
		/// </summary>
		public byte QuestType { get; set; }
		/// <summary>
		/// クエストレベル
		/// </summary>
		public string QuestLevel { get; set; }
		/// <summary>
		/// 対象モンスター
		/// </summary>
		public string TargetMonster { get; set; }
		/// <summary>
		/// 場所
		/// </summary>
		public string Place { get; set; }
	}
}