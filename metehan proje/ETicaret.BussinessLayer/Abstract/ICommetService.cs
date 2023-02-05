using ETicaret.EntityLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.BussinessLayer.Abstract
{
    public interface ICommetService
    {
        Task<Commet> AddAsync(Commet commet);
        Task<Commet> UpdateAsync(Commet commet);
        Task<bool> DeleteByIdAsync(int id);

        Task<List<Commet>> GetListAsync(Expression<Func<Commet, bool>> filter = null);

        Task<Commet> GetAsync(Expression<Func<Commet, bool>> filter);

        Task<Commet> GetModelByIdAsync(int id);

    }
}
