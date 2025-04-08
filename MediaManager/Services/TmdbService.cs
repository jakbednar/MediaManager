using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using MediaManager.Models;

namespace MediaManager.Services;

public class TmdbService
{
    private readonly HttpClient _http;
    private readonly string _apiKey = "bd2e0f54c7e8f2965ee3ed85a41cc931";

    public TmdbService(HttpClient http)
    {
        _http = http;
    }

    public async Task<List<TmdbMovie>> GetPopularMoviesAsync()
    {
        string url = $"https://api.themoviedb.org/3/movie/popular?api_key={_apiKey}&language=en-US&page=1";
        var response = await _http.GetFromJsonAsync<TmdbResponse>(url);
        return response?.results ?? new List<TmdbMovie>();
    }
}

