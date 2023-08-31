﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FinancasApp.Presentation.Controllers
{
    [Authorize]
    public class ContasController : Controller
    {
        //Contas/Cadastro
        public IActionResult Cadastro()
        {
            return View();
        }

        //Contas/Consulta
        public IActionResult Consulta()
        {
            return View();
        }

        //Contas/Edicao
        public IActionResult Edicao()
        {
            return View();
        }
    }
}



