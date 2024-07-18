using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ToDoList.Models
{
	public class ToDoItem
	{
		public int Id { get; set; }

		[Required]
		[StringLength(100)]
		public string Title { get; set; }

		public string Description { get; set; }

		public bool IsCompleted { get; set; }

		[DataType(DataType.Date)]
		public DateTime DueDate { get; set; }

		[Range(1, 5)]
		public int Priority { get; set; }

		public int UserId { get; set; }

		public User User { get; set; }
	}
}
