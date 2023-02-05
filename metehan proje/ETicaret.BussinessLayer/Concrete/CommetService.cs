using ETicaret.BussinessLayer.Abstract;
using ETicaret.DataAccessLayer.Abstracts;
using ETicaret.EntityLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.BussinessLayer.Concrete
{
    public class CommetService:ICommetService
    {
        private readonly ICommetDal _commetDal;

        public CommetService(ICommetDal commetDal)
        {
            _commetDal = commetDal;
        }

        public async Task<Commet> AddAsync(Commet commet)
        {
            var addCommet = await _commetDal.AddAsync(commet);

            return addCommet;
        }

        public async Task<bool> DeleteByIdAsync(int id)
        {
            return await _commetDal.DeleteByIdAsync(id);
        }

        public async Task<Commet> GetAsync(Expression<Func<Commet, bool>> filter)
        {
            return await _commetDal.GetAsync(filter);

        }

        public async Task<List<Commet>> GetListAsync(Expression<Func<Commet, bool>> filter = null)
        {

            return await _commetDal.GetListAsync(filter);

        }

        public async Task<Commet> GetModelByIdAsync(int id)
        {
            return await _commetDal.GetModelByIdAsync(id);
        }

        public async Task<Commet> UpdateAsync(Commet commet)
        {
            return await _commetDal.UpdateAsync(commet);
        }
    }
}
