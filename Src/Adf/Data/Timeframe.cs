﻿using System;

namespace AutoLead.Data
{
	public class Timeframe
	{
		#region Properties

		public string Description { get; set; }

		public DateTime? EarliestDate { get; set; }

		public DateTime? LatestDate { get; set; }

		#endregion
	}
}
