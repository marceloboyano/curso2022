using IntroduccionMVC.Data;
using IntroduccionMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace introduccionMVC.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index(int? id)
        {
            //if (id == 2)
            //{
            //para devolver una vista especifica segun su nombre
            //    return View("Ejemplo");
            //}

            var ctx = new ApplicationDbContext();

            var usuarios = ctx.Users.ToList();
            List<UserViewModel> models = new List<UserViewModel>();
            foreach (var item in usuarios)
            {
                UserViewModel user = new UserViewModel()
                {
                    Id = item.Id,
                    UserName = item.UserName,
                };
                models.Add(user);
            }
            return View(models);
        }
        public IActionResult Detallex(string id)
        {
          

            var ctx = new ApplicationDbContext();

            var usuario = ctx.Users.FirstOrDefault(x =>x.Id==id);

           
           
                UserViewModel model = new UserViewModel()
                {
                    Id = usuario.Id,
                    UserName = usuario.UserName,
                };             
           
            return View(model);
        }
    }
}
