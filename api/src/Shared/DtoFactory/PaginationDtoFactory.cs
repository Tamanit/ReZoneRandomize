using api.Shared.Dto;

namespace api.Shared.DtoFactory;

public class PaginationDtoFactory
{
    public PaginationDto Create(int page, int total, int limit)
    {
        limit = limit > 0 ? limit : 12;
        var pages = (int)Math.Ceiling(total/(decimal)limit);
        page = page > 0 || page <= pages ? page : 1;

        return new PaginationDto(page, pages, limit);
    }
}
