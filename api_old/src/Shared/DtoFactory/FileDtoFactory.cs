using api.DataBase.Entity;
using api.DataBase.Repository;
using api.Shared.Dto;

namespace api.Shared.DtoFactory;

public class FileDtoFactory
{
    public FileDto Create(FileEntity entity)
    {
        return new FileDto(
            entity.Id,
            entity.Name,
            entity.Type,
            entity.Path,
            entity.Description
        );
    }

    public List<FileDto> CreateList(List<FileEntity> list)
    {
        return list.Select(Create).ToList();
    }
}
