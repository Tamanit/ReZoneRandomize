using api.Shared.Dto;

namespace api.Office.BoardGame.Dto;

public class BoardGameListDto
{
    public PaginationDto pagination { get; set; }
    public List<BoardGameListingElementDto> list { get; set; }
    public BoardGameFilterVariantsDto filters { get; set; }

    public BoardGameListDto(
        PaginationDto pagination,
        List<BoardGameListingElementDto> list,
        BoardGameFilterVariantsDto filters
    ) {
        this.pagination = pagination;
        this.list = list;
        this.filters = filters;
    }
}
