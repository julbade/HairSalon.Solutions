using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;

namespace HairSalon.Controllers
{
public class StylistController : Controller
{

  [HttpGet("/stylists")]
  public ActionResult Index()
  {
    List<Stylist> allStylists = Stylist.GetAll();
    return View(allStylists);
  }

  [HttpGet("/stylists/new")]
  public ActionResult CreateForm()
  {
      return View();
  }

  [HttpPost("/stylists")]
  public ActionResult Create()
  {
      Stylist newStylist = new Stylist(Request.Form["new-stylist"]);
      newStylist.Save();
      List<Stylist> allStylists = Stylist.GetAll();
      return RedirectToAction("Index");
  }

  [HttpGet("/stylists/{id}")]
  public ActionResult Details(int id)
  {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Stylist selectedStylist = Stylist.Find(id);
      List<Client> stylistClients = selectedStylist.GetClients();
      model.Add("stylist", selectedStylist);
      model.Add("client", stylistClients);
      return View(model);
  }

  [HttpPost("/clients")]
  public ActionResult CreateClient(int stylistId, string clientName)
  {
     Dictionary<string, object> model = new Dictionary<string, object>();
     Stylist foundStylist = Stylist.Find(stylistId);
     Client newClient = new Client(clientName, stylistId);
     foundStylist.Add(newClient);
     List<Client> stylistClients = foundStylist.GetClients();
     model.Add("clients", stylistClients);
     model.Add("stylist", foundStylist);
     return View("Details", model);
   }

  [HttpPost("/stylists/delete")]
  public ActionResult DeleteAll()
  {

    Stylist.DeleteAll();
    return View();
  }

 }
}
