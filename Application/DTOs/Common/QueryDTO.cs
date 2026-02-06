namespace Application.DTOs.Common;

public class QueryDTO<T>
{
    public int Total { set; get; }
    public T? Query { set; get; } 
}
