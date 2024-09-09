using api.Shared.Dto;
using api.Shared.Errors;

namespace api.Shared.DtoFactory;

public class ErrorDtoFactory
{
    public ErrorDto Create(Error error)
    {
        return new ErrorDto(
            code: (int)error.Code,
            message: error.Message,
            statusCode: error.Status
        );
    }
    
    public ErrorDto Create(Exception error)
    {
        return new ErrorDto(
            code: 888,
            message: error.Message,
            statusCode: 500
        );
    }
}
