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
    public class ImageManager : IImageService
    {
        private readonly IImageDal _imageDal;
        public ImageManager(IImageDal imageDal)
        {
            _imageDal = imageDal;
        }

        public void Add(Image entity)
        {
            _imageDal.Add(entity);
        }

        public void Delete(Image entity)
        {
           _imageDal.Delete(entity);
        }

        public Image GetById(int id)
        {
            return _imageDal.GetById(id);
        }

        public List<Image> GetListAll()
        {
            return _imageDal.GetListAll();
        }

        public void Update(Image entity)
        {
           _imageDal.Update(entity);
        }
    }
}
