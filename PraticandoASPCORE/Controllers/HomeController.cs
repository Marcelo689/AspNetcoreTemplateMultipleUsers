using Microsoft.AspNetCore.Mvc;
using PraticandoASPCORE.Contexto;
using PraticandoASPCORE.Models;
using PraticandoASPCORE.ViewModel;
using System.Diagnostics;

namespace PraticandoASPCORE.Controllers
{
    public class HomeController : Controller
    {
        public List<User> UsuariosLogados { get; set; } = new List<User>();   
        
        private readonly ILogger<HomeController> _logger;
        private readonly MvcContext contexto;

        public HomeController(ILogger<HomeController> logger, MvcContext contexto)
        {
            _logger = logger;
            this.contexto = contexto;
        }

        public IActionResult Index()
        {
            var meuUsuario = new User();
            var ip = HttpContext.Connection.RemoteIpAddress.ToString();
            meuUsuario.Ip = ip;
            meuUsuario.Name = "Marcelo";
            meuUsuario.Password = "123";

            var listUsers = contexto.Users.ToList();
            if(listUsers.Count == 0)
            {
                contexto.Users.Add(meuUsuario);
                contexto.SaveChanges();
            }else
            if (listUsers.First(e => e.Ip == ip) == null)
            {
                contexto.Users.Add(meuUsuario); 
                contexto.SaveChanges();
            }
            
            var viewModel = new HomeViewModel();

            viewModel.Users = contexto.Users.ToList(); ;
            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}