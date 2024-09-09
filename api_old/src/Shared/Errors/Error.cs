namespace api.Shared.Errors;

public class Error: Exception
{
    public ErrorCode Code { get; set; }
    public int Status { get; set; }
    public string Message { get; set; }

    public Error(ErrorCode code, int status, string message)
    {
        Code = code;
        Status = status;
        Message = message;
    }
}