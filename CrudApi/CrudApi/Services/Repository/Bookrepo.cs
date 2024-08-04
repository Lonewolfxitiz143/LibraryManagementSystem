using CrudApi.Data;
using CrudApi.Model_Entities;
using CrudApi.Services.Interface;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CrudApi.Services.Repository
{
    public class Bookrepo:IBookRepo
    {
        private readonly Bookdbcontext dbcontext;

        public Bookrepo(Bookdbcontext Dbcontext)
        {
            dbcontext = Dbcontext;
        }
        
        public async Task<List<Studentsdb>> ListBook()
        {
            var data= await dbcontext.Booktable.ToListAsync();
            return data;
           
        }
        public async Task AddBook(Studentsdb obj)
        {
            await dbcontext.Booktable.AddAsync(obj);
            await dbcontext.SaveChangesAsync();
            
        }
        public async Task<Studentsdb> DeleteBook(int id) {
            var data = await dbcontext.Booktable.FindAsync(id);
            if (data != null)
            {
                dbcontext.Booktable.Remove(data);
                await dbcontext.SaveChangesAsync();
            }        
            return data;
           
        }
        public async Task<Studentsdb> GetById(int id)
        {
            var data = await dbcontext.Booktable.FindAsync(id);
            return data;
        }
    }
}
