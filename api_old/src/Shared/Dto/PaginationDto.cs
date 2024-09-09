namespace api.Shared.Dto;

public class PaginationDto
{
    public int page { get; set; }
    public int pages { get; set; }
    public int page_size { get; set; }

    public PaginationDto(int page, int pages, int pageSize)
    {
        this.page = page;
        this.pages = pages;
        this.page_size = pageSize;
    }
}
