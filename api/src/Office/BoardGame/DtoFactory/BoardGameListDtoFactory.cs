using api.Office.BoardGame.Dto;
using api.Shared.Dto;

namespace api.Office.BoardGame.DtoFactory;

public class BoardGameListDtoFactory
{
    public BoardGameListDto Create(
        PaginationDto pagination,
        List<BoardGameListingElementDto> list,
        BoardGameFilterVariantsDto filters
    )
    {
        return new BoardGameListDto(
            pagination,
            list,
            filters
        );
    }
}
