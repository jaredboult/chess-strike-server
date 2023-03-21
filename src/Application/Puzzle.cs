namespace ChessStrike.Application;

public class Puzzle
{
    public required string PuzzleId { get; init; }
    public required string StartingPosition { get; init; }
    public required ICollection<string> Moves { get; init; }
    public required int Rating { get; init; }
    public required int RatingDeviation { get; init; }
    public required int Popularity { get; init; }
    public required int NumberOfPlays { get; init; }
    public required ICollection<string> Themes { get; init; }
    public string? GameUrl { get; init; }
    public required ICollection<string> OpeningTags { get; init; }
}