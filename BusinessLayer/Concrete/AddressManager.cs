using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AddressManager : IAddressService
    {
        private readonly IAddressDal _addressDal;
        public AddressManager(IAddressDal addressDal)
        {
            _addressDal = addressDal;
        }
        public void Add(Address entity)
        {
            _addressDal.Add(entity);
        }

        public void Delete(Address entity)
        {
           _addressDal.Delete(entity);
        }

        public Address GetById(int id)
        {
            return _addressDal.GetById(id);
        }

        public List<Address> GetListAll()
        {
            return _addressDal.GetListAll();
        }

        public void Update(Address entity)
        {
            _addressDal.Update(entity);
        }
    }
}
