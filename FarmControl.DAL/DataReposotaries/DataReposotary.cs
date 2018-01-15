using FarmControl.DAL.DataBaseContext;
using FarmControl.DAL.DataInterface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmControl.DAL.DataReposotaries
{
    public class DataReposotary<TEntity> : IDataReposotary<TEntity> where TEntity : class
    {
        protected FarmManagmentDBContext _context;
        protected DbSet<TEntity> _dbset;
        public DataReposotary(FarmManagmentDBContext context)
        {
            _context = context;
            _dbset = context.Set<TEntity>();
        }
        public void Add(TEntity newentity, string _UserName = "")
        {
            try
            {

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public Task AddAsync(TEntity newentity, string _UserName = "")
        {
            throw new NotImplementedException();
        }

        public string CaptureException(Exception ex, TEntity newentity = null, string _UserName = "")
        {
            throw new NotImplementedException();
        }

        public Task<string> CaptureExceptionAsync(Exception ex, TEntity newentity = null, string _UserName = "")
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntity entity, string _UserName = "")
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(TEntity entity, string _UserName = "")
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll(int id = 0, string _UserName = "")
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TEntity>> GetAllAsync(int id = 0, string _UserName = "")
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAllByCustomIDs(string _UserName = "", params int[] ids)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TEntity>> GetAllByCustomIDsAsync(string _UserName = "", params int[] ids)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAllByName(string SearchName, string _UserName = "")
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TEntity>> GetAllByNameAsync(string SearchName, string _UserName = "")
        {
            throw new NotImplementedException();
        }

        public TEntity GetByCustomIDs(string _UserName = "", params int[] ids)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetByCustomIDsAsync(string _UserName = "", params int[] ids)
        {
            throw new NotImplementedException();
        }

        public TEntity GetByID(int id, string _UserName = "")
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetByIDAsync(int id, string _UserName = "")
        {
            throw new NotImplementedException();
        }

        public void SaveToDataBase(string _UserName = "")
        {
            throw new NotImplementedException();
        }

        public Task SaveToDataBaseAsync(string _UserName = "")
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity, string _UserName = "")
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(TEntity entity, string _UserName = "")
        {
            throw new NotImplementedException();
        }
    }
}
