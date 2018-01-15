using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FarmControl.DAL.DataInterface
{
    public interface IDataReposotary<TEntity> where TEntity : class
    {
        Task SaveToDataBaseAsync(string _UserName = "");
        void SaveToDataBase(string _UserName = "");
        Task DeleteAsync(TEntity entity, string _UserName = "");
        void Delete(TEntity entity, string _UserName = "");
        IEnumerable<TEntity> GetAll(int id = 0, string _UserName = "");
        Task<IEnumerable<TEntity>> GetAllAsync(int id = 0, string _UserName = "");
        IEnumerable<TEntity> GetAllByCustomIDs(string _UserName = "", params int[] ids);
        Task<IEnumerable<TEntity>> GetAllByCustomIDsAsync(string _UserName = "", params int[] ids);

        Task<TEntity> GetByIDAsync(int id, string _UserName = "");
        TEntity GetByID(int id, string _UserName = "");
        Task<IEnumerable<TEntity>> GetAllByNameAsync(string SearchName, string _UserName = "");
        IEnumerable<TEntity> GetAllByName(string SearchName, string _UserName = "");
       
        Task<TEntity> GetByCustomIDsAsync(string _UserName = "", params int[] ids);
        TEntity GetByCustomIDs(string _UserName = "", params int[] ids);
        Task AddAsync(TEntity newentity, string _UserName = "");
        void Add(TEntity newentity, string _UserName = "");
        Task UpdateAsync(TEntity entity, string _UserName = "");
        void Update(TEntity entity, string _UserName = "");

        Task<string> CaptureExceptionAsync(Exception ex, TEntity newentity = null, string _UserName = "");
        string CaptureException(Exception ex, TEntity newentity = null, string _UserName = "");
    }
}
