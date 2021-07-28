using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CodingEventsDemo.ViewModels
{
	
	public class AddEventViewModel
	{
		[Required(ErrorMessage = "Name is required.")]
		[StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters.")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Please enter a description for your event.")]
		[StringLength(500, MinimumLength = 3, ErrorMessage = "Description must be between 3 and 500 characters.")]
		public string Description { get; set; }

		[Required(ErrorMessage = "Please enter a location for your event.")]
		[StringLength(500, MinimumLength = 3, ErrorMessage = "Location must be between 2 and 20 characters.")]
		public string EventLocation { get; set; }

		[Required(ErrorMessage = "Please enter a valid number of attendees for your event.")]
		[Range(1, 300, ErrorMessage = "Number of attendees must be greater than 0.")]
		public int NumOfAttendees { get; set; }

		//[Required(ErrorMessage = "Please enter a valid Email for your event.")]
		[EmailAddress]
		public string ContactEmail { get; set; }
	}
}
