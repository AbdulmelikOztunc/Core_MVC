using BusinessLayer.Concrete;
using DataAcsessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Views.Shared.Components.Testimonial
{
    public class TestimonialList:ViewComponent
    {
        TestimonialManager testimonialManager=new TestimonialManager(new EfTestimmonialDal());
        public IViewComponentResult Invoke()
        {
            var values = testimonialManager.TGetList();
            return  View(values);
        }
    }
}
