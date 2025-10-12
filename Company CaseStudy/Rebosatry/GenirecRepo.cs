using Company_CaseStudy.Data;
using Company_CaseStudy.Interface;
using Microsoft.EntityFrameworkCore;

namespace Company_CaseStudy.Rebosatry
{
    public class GenirecRepo <T> : IGenirec<T> where T : class
    {
        protected readonly AppDbContext _context;

        public GenirecRepo(AppDbContext context)
        {
            _context = context;
        }
        public async Task <List<T>>  GetAll()
        {
           return await _context.Set<T>().ToListAsync();
        }

        public async Task Add(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();

        }

        public async Task Update(T entity)
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var del = await Getbyid(id);
            if (del != null)
            {
                _context.Set<T>().Remove(del);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<T?> Getbyid(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }
    }
}
