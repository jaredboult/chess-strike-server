using ChessStrike.Application;
using Microsoft.AspNetCore.Mvc;

namespace ChessStrike.Presentation.Controllers;

[ApiController]
[Route("[controller]")]
public class PuzzleController : ControllerBase
{
    private readonly ILogger<PuzzleController> _logger;

    public PuzzleController(ILogger<PuzzleController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetPuzzle")]
    public Puzzle Get()
    {
        return new Puzzle
        {
            PuzzleId = "00sHx",
            StartingPosition = "q3k1nr/1pp1nQpp/3p4/1P2p3/4P3/B1PP1b2/B5PP/5K2 b k - 0 17",
            Moves = new List<string>()
            {
                "e8d7",
                "a2e6",
                "d7d8",
                "f7f8"
            },
            Rating = 1760,
            RatingDeviation = 80,
            Popularity = 83,
            NumberOfPlays = 72,
            Themes = new List<string>()
            {
                "mate",
                "mateIn2",
                "middlegame",
                "short"
            },
            GameUrl = "https://lichess.org/yyznGmXs/black#34",
            OpeningTags = new List<string>()
            {
                "Italian_Game",
                "Italian_Game_Classical_Variation"
            }
        };
    }
}