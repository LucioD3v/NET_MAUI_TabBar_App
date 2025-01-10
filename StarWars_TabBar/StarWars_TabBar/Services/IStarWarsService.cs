using StarWars_TabBar.Models;

namespace StarWars_TabBar.Services
{
    public interface IStarWarsService
    {
        //Método (Tarea Asincrona)
        public Task<List<DataModel>> GetPersonajesAsync();
        public Task<List<DataModel>> GetPlanetsAsync();
        public Task<List<DataModel>> GetStarShipsAsync();
    }
}