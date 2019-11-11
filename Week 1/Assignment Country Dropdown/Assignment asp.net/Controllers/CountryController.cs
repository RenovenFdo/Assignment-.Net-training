using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment_asp.net.Models;


namespace Assignment_asp.net.Controllers
{
    public class CountryController : Controller
    {
        // GET: Country
        public ActionResult Index()
        {
            assignmentEntities countrylist = new assignmentEntities();
            ViewBag.country = new SelectList(GetCountries(), "id", "name");
            return View();
        }
        public List<country> GetCountries()
        {
            assignmentEntities countrylist = new assignmentEntities();
            List<country> countries = countrylist.countries.ToList();
            return countries;
        }
        public ActionResult GetStates(int cid)
        {
            assignmentEntities countrylist = new assignmentEntities();
            List<state> states = countrylist.states.Where(x => x.countryid == cid).ToList();
            ViewBag.states = new SelectList(states, "id", "name");
            return PartialView("States");
          
        }
        

    
            //public ActionResult Index()
            //{
            //    List<tblCountry> countrylist = GetCountries();
            //    ViewBag.countries = new SelectList(countrylist, "country_id", "country");
            //    ViewBag.id = 0;
            //    return View();
            //}

            //public List<tblCountry> GetCountries()
            //{
            //    List<tblCountry> countrylist = entity.tblCountries.ToList();
            //    return countrylist;
            //}

            //public ActionResult GetState(int cid)
            //{
            //    List<tblCountry> countrylist = GetCountries();
            //    ViewBag.countries = new SelectList(countrylist, "country_id", "country");

            //    return View();
            //}
        }
    }

