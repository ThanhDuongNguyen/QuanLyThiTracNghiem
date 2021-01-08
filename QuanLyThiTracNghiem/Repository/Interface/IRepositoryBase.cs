using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThiTracNghiem.Repository.Interface
{
    public interface IRepositoryBase<T> where T : class
    {
        IQueryable<T> FindAll(); // tìm kiếm tất cả
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression); // tìm kiếm có điều kiện linq
        void Create(T entity); // thêm
        void Update(); // sửa 
        void Delete(T entity); // xóa
    }
}
