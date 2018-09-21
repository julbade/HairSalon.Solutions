using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;

namespace HairSalon.Controllers
{
  public class ClientController : Controller
  {
    [HttpGet("/stylists/{stylistId}/clinets/new")]
    public ActionResult CreateForm(int stylistId)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Stylist stylist = Stylist.Find(stylistId);
      return View(stylist);
    }

    [HttpGet("/stylists/{stylistId}/clinets/{clientId}")]
    public ActionResult Details(int stylistId, int clientId)
    {
      Client client = Client.Find(clientId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      Stylist stylist = Stylist.Find(stylistId);
      model.Add("client", client);
      model.Add("stylist", stylist);
      return View(client);
    }

    // [HttpGet("/{id}/clients")]
    // public ActionResult Index()
    // {
    //   List<Client> allClients = Client.GetAll();
    //   return View(allClients);
    // }

    // [HttpGet("/{id}/clients/new")]
    // public ActionResult CreateForm()
    // {
    //   return View();
    // }
    //
    // [HttpPost("{id}/clients")]
    // public ActionResult Create()
    // {
    //   Client newClient = new Client(Request.Form["new-client"]);
    //   newClient.Save();
    //   List<Client> allClients = Client.GetAll();
    //   return RedirectToAction("Details");
    }



  }
