using api.Office.BoardGame.Request;
using api.Shared.Errors;

namespace api.Office.BoardGame.Service;

public class ValidateService
{
    public void CreateBoardGameValidate(CreateOrUpdateRequest request)
    {
        if (request.id != null &&
            request.name == null &&
            request.code == null &&
            request.active == null)
            throw new Error(ErrorCode.ValidateFailed, 412, "Не заполнены необходимые поля для создания");
    }
}
