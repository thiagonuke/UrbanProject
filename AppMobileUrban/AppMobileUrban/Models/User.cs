﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMobileUrban.Models
{
	public class User
	{
		public int Id { get; set; }
		public string Email { get; set; }
		public string Senha { get; set; }
		public string Nome { get; set; }
		bool Administrador { get; set; }
	}
}
