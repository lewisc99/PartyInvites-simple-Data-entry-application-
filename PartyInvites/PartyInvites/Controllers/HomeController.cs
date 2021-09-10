using Microsoft.AspNetCore.Mvc;
using System;
using PartyInvites.Models;
using System.Linq;

// Created a Home controller, where return a View of the httpGet, passing the same input the user input,
// and use the http post to send to the class repository the user's form input.
// then return the View Thanks plus the guestResponse.

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good morning" : "Goord Afternoon";
            return View("MyView");
        }


        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {   if (ModelState.IsValid) { 
            Repository.AddResponses(guestResponse);
            return View("Thanks", guestResponse);

            }
            else
            {
                return View();
            }
        }

        public ViewResult ListResponses()
        {
            return View(Repository.Responses.Where(r => r.WillAttend == true));
        }
    }
}