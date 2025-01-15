using System.Text.Json;
using StarWars_TabBar.Models;
using System.Text.Json.Nodes;

namespace StarWars_TabBar.Services
{
    public class StarWarsService : IStarWarsService
    {
        // Variable privada
        private string urlAPI = "https://swapi.py4e.com/api/";

        // Interface
        public async Task<List<DataModel>> GetPersonajesAsync()
        {
            var client = new HttpClient();
            var response = await client.GetAsync(urlAPI + "people/");
            var responseBody = await response.Content.ReadAsStringAsync();
            JsonNode nodos = JsonNode.Parse(responseBody);
            JsonNode results = nodos["results"];

            var personajeData = JsonSerializer.Deserialize<List<DataModel>>(results.ToString());
            return personajeData;
        }

        public async Task<List<DataModel>> GetPlanetsAsync()
        {
            var client = new HttpClient();
            var response = await client.GetAsync(urlAPI + "planets/");
            var responseBody = await response.Content.ReadAsStringAsync();
            JsonNode nodos = JsonNode.Parse(responseBody);
            JsonNode results = nodos["results"];

            var planetsData = JsonSerializer.Deserialize<List<DataModel>>(results.ToString());
            return planetsData;
        }

        public async Task<List<DataModel>> GetStarShipsAsync()
        {
            var client = new HttpClient();
            var response = await client.GetAsync(urlAPI + "starships/");
            var responseBody = await response.Content.ReadAsStringAsync();
            JsonNode nodos = JsonNode.Parse(responseBody);
            JsonNode results = nodos["results"];

            var starshipsData = JsonSerializer.Deserialize<List<DataModel>>(results.ToString());
            return starshipsData;
        }
    }
}

