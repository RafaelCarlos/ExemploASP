using ExemploValidacao.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExemploValidacao.Controllers
{
    public class PessoaController : Controller
    {

        public ActionResult Index()
        {
            var pessoa = new Pessoa();

            return View();
        }

        [HttpPost]
        public ActionResult Index(Pessoa pessoa)
        {
            //Validação dos campos nome e senha.
            //if(string.IsNullOrEmpty(pessoa.Nome))
            //{
            //    ModelState.AddModelError("Nome", "Preencha o nome campo");
            //}

            //if(pessoa.Senha != pessoa.ConfirmarSenha)
            //{
            //    ModelState.AddModelError("", "Senhas não conferem");
            //}



            if(ModelState.IsValid)
            {
                return View("Resultado", pessoa);
            }
            return View(pessoa);
        }

        public ActionResult Resultado(Pessoa pessoa)
        {
            return View(pessoa);
        }

        public ActionResult LoginUnico(string login)
        {
            var bancoExemplo = new Collection<String>
            {
                "Rafael",
                 "Sequela",
                 "Radhar"
            };

            //Para cada registro, trasforme tudo para minusculo
            return Json(bancoExemplo.All(x => x.ToLower() != login.ToLower()) , JsonRequestBehavior.AllowGet); 
        }

    }
}
