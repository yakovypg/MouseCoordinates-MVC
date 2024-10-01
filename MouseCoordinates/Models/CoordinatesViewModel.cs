using System.ComponentModel.DataAnnotations;

namespace MouseCoordinates.Models;

public class CoordinatesViewModel
{
    public CoordinatesViewModel(string jsonValue)
    {
        JsonValue = jsonValue;
    }

    [Key]
    public int Id { get; set; }

    public string JsonValue { get; set; }
}
