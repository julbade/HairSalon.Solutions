using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;

namespace HairSalon.Controllers
{
  public class ClientController : Controller
  {
    [HttpGet("/{id}/clients")]
    public ActionResult Index()
    {
      List<Client> allClients = Client.GetAll();
      return View(allClients);
    }

    [HttpGet("/{id}/clients/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("{id}/clients")]
    public ActionResult Create()
    {
      Client newClient = new Client(Request.Form["new-client"]);
      newClient.Save();
      List<Client> allClients = Client.GetAll();
      return RedirectToAction("Details");
    }


  }
}
