﻿using Microsoft.AspNetCore.Mvc;

namespace BulkyWeb.Controllers
{
    public class CategoryController : Controller
    {
        /*
         Un dato importante es que al generar un controlador, en los return View se puede pasar en el View() como parámetro el nombre del archivo en questión Index y lo buscará 
         en las carpetas de view con el nombre del controlador o la shared.

            Pero si no indicamos nada, lo que hará es buscar un archivo que se llame igual que el método que lo invoca
            únicamente en las carpetas de shared y en una si la hay llamada igual que el nombre del controlador en este caso Category, dentro de la carpeta views.
         
         */

        public IActionResult Index()
        {
            return View();
        }
    }
}