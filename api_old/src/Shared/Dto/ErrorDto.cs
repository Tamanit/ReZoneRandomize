namespace api.Shared.Dto;

public class ErrorDto
{
    public int code { get; set; }
    public string message { get; set; }
    public int statusCode { get; set; }

    public ErrorDto(int code, int statusCode, string message)
    {
        this.code = code;
        this.message = message;
        this.statusCode = statusCode;
    }
}
