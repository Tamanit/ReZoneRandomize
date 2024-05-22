using System.ComponentModel.DataAnnotations;

namespace api.Office.BoardGame.Request;

public class IdRequest
{
    [Required]
    [RegularExpression( @"(?im)^[{(]?[0-9A-F]{8}[-]?(?:[0-9A-F]{4}[-]?){3}[0-9A-F]{12}[)}]?$",
        ErrorMessage = "this is not valid Guid")]
    public string Id { get; set; }
}
