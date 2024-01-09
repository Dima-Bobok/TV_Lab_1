using Microsoft.AspNetCore.Mvc;

namespace TV_Lab_1.Components
{
    public class CartViewComponent : ViewComponent
    {
        //public CartViewComponent() 
        //{
        
        //}
        
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }

}
