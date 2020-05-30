using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace JocosAdvertisement.Models
{
	public class Car
	{
		public int CarId { get; set; }
		public string Brand { get; set; }
		public string Model { get; set; }
		public decimal Price { get; set; }
		public string Description { get; set; }
		public string Image { get; set; }

	}
}