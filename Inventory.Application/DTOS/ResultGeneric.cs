using Inventory.Application.Common.Exceptions;

namespace Inventory.Application.DTOS;

public class Result<T> : Result
{
    public T? Data { get; set; }

    public static Result<T> Success(T data, string message = "")
    {
        return new Result<T>
        {
            Succeeded = true,
            Data = data,
            Message = message
        };
    }

    public new static Result<T> Failure(string message)
    {
        return new Result<T>
        {
            Succeeded = false,
            Message = message
        };
    }
}