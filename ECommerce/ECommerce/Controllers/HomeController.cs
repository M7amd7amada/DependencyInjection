﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ECommerce.Models;
using ECommerce.Utility.Services;

namespace ECommerce.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly AppDbContext _dbContext;

    public HomeController(ILogger<HomeController> logger, AppDbContext dbContext)
    {
        _logger = logger;
        _dbContext = dbContext;
    }

    public IActionResult Index()
    {
        bool isPreferredCustomer =
            this.User.IsInRole("PreferredCustomer");

        var service = new ProductService(_dbContext);
        var products =
            service.GetFeaturedProducts(isPreferredCustomer);

        return View(products);
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
