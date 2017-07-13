using Accounting.Attribute;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCVerify.Models.ViewModel
{
	public class LoginViewModel
	{
		[Required]
		[BanAccount]
		[EmailAddress]
		[Display(Name = "帳號")]
		public string Account { get; set; }

		[Required]
		[DataType(DataType.Password)]
		[StringLength(20, ErrorMessage = "{0}長度必須介於{1}到{2}之間", MinimumLength = 4)]
		[Display(Name = "密碼")]
		public string Password { get; set; }
	}
}