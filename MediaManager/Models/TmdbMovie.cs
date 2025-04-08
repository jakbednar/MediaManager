namespace MediaManager.Models;

public class TmdbMovie
{
    public int id { get; set; }
    public string title { get; set; } = string.Empty;
    public string overview { get; set; } = string.Empty;
    public string poster_path { get; set; } = string.Empty;
    public string release_date { get; set; } = string.Empty;
    public double vote_average { get; set; }
}

public class TmdbResponse
{
    public int page { get; set; }
    public List<TmdbMovie> results { get; set; } = new();
}
