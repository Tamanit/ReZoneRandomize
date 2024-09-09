using System.ComponentModel.DataAnnotations.Schema;

namespace api.DataBase.Entity;

public class BoardGameEntity
{
    //require fields
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Code { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdateAt { get; set; }
    public bool Active { get; set; }
    
    //non-require fields
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? Rules { get; set; }
    
    //forein keys

    public Guid? AgeRestrictionId { get; set; }
    public Guid? PreviewImageId { get; set; }
    public Guid? PlayerCountId { get; set; }
    public Guid? DifficultyId { get; set; }
    
    //relations
    [ForeignKey("AgeRestrictionId")]
    public AgeRestrictionEntity? AgeRestriction { get; set; }
    
    [ForeignKey("PreviewImageId")]
    public FileEntity? PreviewImage { get; set; }

    public List<FileEntity>? Images { get; set; }
    
    [ForeignKey("PlayerCountId")]
    public PlayerCountEntity? PlayerCount { get; set; }
    
    [ForeignKey("DifficultyId")]
    public DifficultyEntity? Difficulty { get; set; }

    public List<NoteEntity>? Notes { get; set; }

    public List<CommentaryEntity>? Commentary { get; set; }
}
