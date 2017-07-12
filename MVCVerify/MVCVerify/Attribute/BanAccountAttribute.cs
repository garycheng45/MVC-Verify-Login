using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Accounting.Attribute
{
	public sealed class BanAccountAttribute : ValidationAttribute
	{
		//public string Input { get; set; }
		private string[] _BanWords;
		

		public BanAccountAttribute()
		{
			_BanWords = new string[] { "demo", "skilltree", "twmvc" };
		}
		public override bool IsValid(object value)
		{
			//權責分清楚，沒有輸入不算錯
			if (value == null)
			{
				return true;
			}

			if (value is string)
			{
				//輸入值是字串才判斷
				foreach(var banword in _BanWords)
				{
					if (value.ToString().Trim().ToLower().Contains(banword))
					{
						ErrorMessage = string.Format(ErrorMessage, banword);
						return false;
					}
				}
			}
			return true;
		}
	}
}