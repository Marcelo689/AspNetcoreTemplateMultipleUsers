using Microsoft.AspNetCore.Mvc;
using PraticandoASPCORE.Models;

namespace PraticandoASPCORE.Controllers
{
    public class ConfiguracaoController : Controller
    {
        public IActionResult Index(Configuracao config)
        {
            if(!config.Equals(config.GetConfigSalva()))
            config = config.GetConfigSalva();
            if(ModelState.IsValid)
            {
                config.Fruta = "fffffffffff";
                config.AtualizaConfiguracao();
            }
            return View(config);
        }
        [HttpPost]
        public IActionResult Update(Configuracao config)
        {
            if (ModelState.IsValid)
            {
                config.Fruta = "fffffffffff";
                config.AtualizaConfiguracao();
            }
            return View(config);
        }
    }
}
