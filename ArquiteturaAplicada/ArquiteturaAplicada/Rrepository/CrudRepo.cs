using ArquiteturaAplicada.Data;
using ArquiteturaAplicada.Rrepository.Interfaces;
using System.Threading.Tasks;

namespace ArquiteturaAplicada.Rrepository
{
    public class CrudRepo : ICrudRepo
    {
        private readonly Context _context;

        public CrudRepo(Context context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }
    }
}
