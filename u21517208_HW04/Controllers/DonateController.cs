using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u21517208_HW04.Models;

namespace u21517208_HW04.Controllers
{
    public class DonateController : Controller
    {
        // GET: Donate
        public ActionResult Donate()
        {
            //List<DonateModel> donor = GetDonor();
            return View(/*donor*/);
        }

        //private List<DonateModel> GetDonor()
        //{
        //    List<DonateModel> Donor = new List<DonateModel>();
            

        //}

    //public ActionResult Index()
    //{
    //    List<CookBookModel> recipes = GetRecipes();
    //    return View(recipes);
    //}

    //private List<CookBookModel> GetRecipes()
    //{
    //    List<CookBookModel> recipes = new List<CookBookModel>();
    //    CookBookModel recipe1 = new CookBookModel("Toast", "Bread and cheese", "Cut cheese and add to bread, then toast it", 2);
    //    CookBookModel recipe2 = new CookBookModel("Fruit salad", "Watermelon", "Cut fruit into cubes", 3);
    //    CookBookModel recipe3 = new CookBookModel("Ramen", "Ramen and spices", "Boil ramen in water , then add sauce", 5);
    //    CookBookModel recipe4 = new CookBookModel("Chicken Toast", "Bread, chicken and cheese", "Cut chicken and add sauce plus cheese, then toast it", 8);
    //    recipes.Add(recipe1);
    //    recipes.Add(recipe2);
    //    recipes.Add(recipe3);
    //    recipes.Add(recipe4);

    //    return recipes;
    //}
}
}