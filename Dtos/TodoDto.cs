namespace AzureFunctionCSharpCrud.Dtos;

public class TodoDto
{
    public int Id { get; set; }

    public string Title { get; set; } = string.Empty;

    public bool IsDone { get; set; }
}