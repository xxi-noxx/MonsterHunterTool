using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonsterHunterTool.Models.Param
{
	public class LotResultParam
	{
		public int PlayerNum { get; set; }
		public IEnumerable<string> PlayerNameList { get; set; }
	}
}