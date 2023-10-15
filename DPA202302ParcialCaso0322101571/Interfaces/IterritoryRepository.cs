using DPA202302ParcialCaso0322101571.Entities;

namespace DPA202302ParcialCaso0322101571.Interfaces
{
    public interface IterritoryRepository
    {
        Task<bool> Delete(int id);
        Task<IEnumerable<Territory>> GetAll();
        Task<bool> Insert(Territory territory);
        Task<bool> Update(int id, Territory territory);
    }
}