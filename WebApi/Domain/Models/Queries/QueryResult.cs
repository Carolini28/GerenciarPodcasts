﻿using System.Collections.Generic;

namespace WebApi.Domain.Models.Queries {
	public class QueryResult<T> {
		public List<T> Items { get; set; } = new List<T>();
		public int TotalItems { get; set; } = 0;
	}
}