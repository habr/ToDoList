using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ToDoList.Models
{
	public class User
	{
		public int Id { get; set; }

		[Required]
		[StringLength(100)]
		public string Name { get; set; }

		[JsonIgnore] // Игнорируем это поле при сериализации, чтобы избежать циклических зависимостей
		public ICollection<ToDoItem> ToDoItems { get; set; } = new List<ToDoItem>();
	}
}
