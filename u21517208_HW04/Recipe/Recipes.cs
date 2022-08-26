using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using u21517208_HW04.Models;

namespace u21517208_HW04.Recipe
{
    public class Recipes
    {
        public static List<CookBookModel> GetRecipes()
        {
            List<CookBookModel> recipes = new List<CookBookModel>();


            recipes.Add(
                new CookBookModel
                {
                    LeadingImage = new Uri("https://simplysidedishes.com/wp-content/uploads/2020/07/Fruit-Salad-Finished-Up-Close-scaled.jpg"),
                    Name = "Fruit salad",
                    Ingredients = "Watermelon, Banana , Apple, BlueBerry, Pineapple, Strawberry, Kiwi",
                    Method = "Wash then Cut fruit into cubes",
                    Serves = 5
                }
                );

            recipes.Add(
                new CookBookModel
                {
                    LeadingImage = new Uri("https://www.foodbymaria.com/wp-content/uploads/2022/02/Instant-Noodles-6-scaled.jpg"),
                    Name = "Ramen",
                    Ingredients = "Ramen noodles and spices",
                    Method = "Boil ramen in water , then add sauce and vegetables",
                    Serves = 10
                }
                );

            recipes.Add(
                new CookBookModel
                {
                    LeadingImage = new Uri("https://thecozycook.com/wp-content/uploads/2022/03/Chicken-and-Broccoli-Pasta-f.jpg"),
                    Name = "Chicken Pasta",
                    Ingredients = "Penne Pasta, Chicken breast, Seasoning, Cream and cheese and broccoli",
                    Method = "Boil pasta, while it is boiling fry and season chicken then add cream and cheese. Finally add in pasta into chicken and mix",
                    Serves = 10
                }
                );

            return recipes;
        }
    }
}