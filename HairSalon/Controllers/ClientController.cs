using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;

namespace HairSalon.Controllers
{
  public class ClientController : Controllers
  {
    [HttpGet("/clients")]
    public ActionResult Index()
    {
      List<Client> allClients = Client.GetAll();
      return View(allClients);
    }

    [HttpGet("/clients/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/clients")]
    public ActionResult Creat()
    {
      Client newClient = new Client(Request.Form["new-client"], Request.Form["stylist-id"]);
      newClient.Save();
      List<Client> allClients = Client.GetAll();
      return RedirectToAction("Index");
    }
  }
}
