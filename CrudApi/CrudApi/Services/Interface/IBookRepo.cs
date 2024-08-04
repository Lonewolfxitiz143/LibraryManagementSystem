using CrudApi.Model_Entities;

namespace CrudApi.Services.Interface
{
    public interface IBookRepo
    {
        Task<List<Studentsdb>> ListBook();
        Task AddBook(Studentsdb obj);
        Task<Studentsdb> DeleteBook(int id);
        Task<Studentsdb> GetById(int id);
    }
}
