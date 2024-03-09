using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        private ITestimonialDal _dal;

        public TestimonialManager(ITestimonialDal dal)
        {
            _dal = dal;
        }
        public void TAdd(Testimonial t)
        {
            _dal.Insert(t);
        }

        public void TDelete(Testimonial t)
        {
            _dal.Delete(t);
        }

        public void TUpdate(Testimonial t)
        {
            _dal.Update(t);
        }

        public List<Testimonial> TGetList()
        {
            return _dal.GetList();
        }

        public Testimonial TGetByID(int id)
        {
            return _dal.GetByID(id);
        }
    }
}
