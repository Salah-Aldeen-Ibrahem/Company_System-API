namespace Company_CaseStudy.Interface
{
    public interface IGenirec<T> where T : class
    {
        Task<List<T>> GetAll();
        Task<T> Getbyid(int  id);   
        Task Add(T entity);
        Task Update(T entity);
        Task Delete(int id);
    }
}
