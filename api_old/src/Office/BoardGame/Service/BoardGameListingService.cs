using api.DataBase.Repository;
using api.Office.BoardGame.Dto;
using api.Office.BoardGame.DtoFactory;
using api.Office.BoardGame.Request;
using api.Shared.DtoFactory;

namespace api.Office.BoardGame.Service;

public class BoardGameListingService
{
    private readonly BoardGameRepository _boardGameRepository = new();
    private readonly PlayerCountRepository _playerCountRepository = new();
    private readonly DifficultyRepository _difficultyRepository = new();
    
    private readonly PaginationDtoFactory _paginationFactory = new();
    private readonly BoardGameListingElementDtoFactory _listFactory = new();
    private readonly PlayerCountDtoFactory _playerCountFactory = new();
    private readonly DifficultyDtoFactory _difficultyFactory = new();
    private readonly BoardGameFilterVariantsDtoFactory _filtersFactory = new();
    private readonly BoardGameListDtoFactory _listingFactory = new();

    public BoardGameListDto Serve(ListingRequest request)
    {
        var totalCount = _boardGameRepository.GetCountByFilters(request);
        var pagination = _paginationFactory.Create(request.page, totalCount, request.limit);
        var offset = (pagination.page - 1) * pagination.page_size;
        
        var list = _listFactory.CreateList(_boardGameRepository.GetByFilters(request, pagination.page_size, offset));

        var filters = _filtersFactory.Create(
            _playerCountFactory.CreateCollection(_playerCountRepository.GetAll()),
            _difficultyFactory.CreateCollection(_difficultyRepository.GetAll())
        );

        return _listingFactory.Create(
            pagination,
            list,
            filters
        );
    }
}
