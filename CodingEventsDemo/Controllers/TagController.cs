using CodingEventsDemo.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingEventsDemo.Controllers
{
	public class TagController : Controller
	{
		private EventDbContext context;

		public TagController(EventDbContext dbContext)
		{
			context = dbContext;
		}
	
		public IActionResult Index()
		{
			List<TagController> tags = context.Tags.ToList();
			return View(tags);
		}
	}
}
