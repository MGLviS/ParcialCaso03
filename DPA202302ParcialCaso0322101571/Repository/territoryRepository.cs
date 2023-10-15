using DPA202302ParcialCaso0322101571.Data;
using DPA202302ParcialCaso0322101571.Entities;
using DPA202302ParcialCaso0322101571.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DPA202302ParcialCaso0322101571.Repository
{
    public class territoryRepository : IterritoryRepository
    {

        private readonly Dpa202302parcialCaso0322101571Context _dbcontext;

        public territoryRepository(Dpa202302parcialCaso0322101571Context dbcontext)
        {
            _dbcontext = dbcontext;
        }

        // CREATE

        public async Task<bool> Insert(Territory territory)
        {
            await _dbcontext.AddAsync(territory);
            var rows = await _dbcontext.SaveChangesAsync();
            return rows > 0;
        }

        //READ

        public async Task<IEnumerable<Territory>> GetAll()
        {
            return await _dbcontext.Territory.ToListAsync();
        }

        //UPDATE

        public async Task<bool> Update(int id, Territory territory)
        {
            var isTerr = await _dbcontext.Territory.FindAsync(id);
            if (isTerr == null)
                return false;

            //isTerr.Id = id;
            isTerr.Description = territory.Description;
            isTerr.Area = territory.Area;
            isTerr.Population = territory.Population;

            var rows = await _dbcontext.SaveChangesAsync();
            return rows > 0;
        }

        //DELETE
        public async Task<bool> Delete(int id)
        {
            var terr = await _dbcontext.Territory.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (terr == null)
                return false;
            _dbcontext.Territory.Remove(terr);
            var rows = await _dbcontext.SaveChangesAsync();
            return rows > 0;
        }

    }
}
