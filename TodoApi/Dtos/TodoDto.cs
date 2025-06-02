// Dtos/TodoDto.cs
namespace TodoApi.Dtos
{
    public class TodoDto
    {
        public string Title { get; set; } = string.Empty;
        public bool IsDone { get; set; } = false;
    }
}
// This code defines a DTO (Data Transfer Object) class named TodoDto.
// The TodoDto class has two properties: Title and IsDone.      