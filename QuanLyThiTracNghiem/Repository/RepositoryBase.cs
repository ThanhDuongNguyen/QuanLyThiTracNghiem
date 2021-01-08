using QuanLyThiTracNghiem.Repository.Interface;
using QuanLyThiTracNghiem.Data;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace QuanLyThiTracNghiem.Repository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected QuanLyThiDataContext _quanLyThiDataContext;

        public RepositoryBase()
        {
            _quanLyThiDataContext = new QuanLyThiDataContext();
        }
        public void Create(T entity)
        {
            GetTable.InsertOnSubmit(entity);
        }

        public void Delete(T entity)
        {
            GetTable.DeleteOnSubmit(entity);
        }

        public void Update()
        {
            _quanLyThiDataContext.SubmitChanges();
        }

        public IQueryable<T> FindAll()
        {
            return GetTable;
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return GetTable.Where<T>(expression);
        }

        private System.Data.Linq.Table<T> GetTable
        {
            get
            {
                return _quanLyThiDataContext.GetTable<T>();
            }
        }
    }
}
