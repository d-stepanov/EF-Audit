﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Audit
{
	class Bank
	{
		public int BankId { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }
		public string Account { get; set; }
		public int ClientId { get; set; }
		public virtual Client Client { get; set; }
	}
}
