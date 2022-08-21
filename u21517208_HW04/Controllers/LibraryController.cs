using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u21517208_HW04.Models;

namespace u21517208_HW04.Views.Library
{
    public class LibraryController : Controller
    {
        // GET: Library
        public ActionResult Gallery()
        {
            List<Gallery> pics = GetPics();
            return View(pics);
        }

        private List<Gallery> GetPics()
        {
            List<Gallery> pics = new List<Gallery>();
            Gallery p1 = new Gallery("Toast", "Centurion", 200);
            Gallery p2 = new Gallery("Fruit salad", "Pretoria CBD", 350);
            Gallery p3 = new Gallery("Ramen", "Reitondale", 500);

            pics.Add(p1);
            pics.Add(p2);
            pics.Add(p3);
            return pics;

        }

        public ActionResult HowToPlant()
        {
            List<HowToPlantModel> howto = GetPlants();
            return View(howto);
        }
        private List<HowToPlantModel> GetPlants()
        {
            List<HowToPlantModel> howto = new List<HowToPlantModel>();
            HowToPlantModel howto1 = new HowToPlantModel("Corn", 8, ", medium-textured and loose, well-drained, high in water-holding capacity", "plant seeds 1.5 to two inches deep, five to six inches apart in rows that are two to three feet apart.");
            HowToPlantModel howto2 = new HowToPlantModel("Spinach", 6, " well-drained soil rich in organic matter ", "Sow seeds 1/2 of an inch deep every 2 inches and cover with 1/2 inch of soil");
            HowToPlantModel howto3 = new HowToPlantModel("Bean", 9, "Sandy and silty loam soil", "Make small holes in the soil about 1.5 centimetres deep and 20 centimetres apart");


            howto.Add(howto1);
            howto.Add(howto2);
            howto.Add(howto3);


            return howto;
        }
        public ActionResult WhichPlantsToGrow()
        {
            List<WhichPlantsToGrowModel> grow = GetGrowth();
            return View(grow);
        }
        private List<WhichPlantsToGrowModel> GetGrowth()
        {
            List<WhichPlantsToGrowModel > grow = new List<WhichPlantsToGrowModel>();
            WhichPlantsToGrowModel grow1 = new WhichPlantsToGrowModel("corn", "warm,sunny");
            WhichPlantsToGrowModel grow2 = new WhichPlantsToGrowModel("Spinach", "cool-weather");
            WhichPlantsToGrowModel grow3 = new WhichPlantsToGrowModel("Beans", "spring");


            grow.Add(grow1);
            grow.Add(grow2);
            grow.Add(grow3);


            return grow;
        }

       

    }    
}