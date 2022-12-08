﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProductApp.Models;

namespace ProductApp.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
       
        string msg = "Anında Nakit!";
        return View("Index",msg);
    }

    public IActionResult Privacy()
    {
        return View();
    }

   

    
}
