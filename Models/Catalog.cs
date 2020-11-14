﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aloai.Models
{
    public class M_CATALOG
    {
		[Key]
		public decimal CATALOG_CD { get; set; }

		public string CATALOG_NAME { get; set; }

		public string CATALOG_NAME_EN { get; set; }

		public decimal DISP_ORDER { get; set; }

		public decimal SHOW_FLG { get; set; }

		public decimal DELETE_FLG { get; set; }

		public DateTime? REG_DATETIME { get; set; }

		public decimal? REG_USER_ID { get; set; }

		public DateTime? UPD_DATETIME { get; set; }

		public decimal? UPD_USER_ID { get; set; }
	}
}