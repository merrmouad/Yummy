using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Yummy.Data;
using System;
using System.Linq;

namespace Yummy.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new YummyContext(
                serviceProvider.GetRequiredService<DbContextOptions<YummyContext>>()))
            {
                // Look for any recipes.
                if (context.Recipes.Any())
                {
                    return;   // DB has been seeded
                }

                try
                {
                    context.Recipes.AddRange(
                        new Recipes
                        {
                            Name = "Spaghetti Carbonara",
                            Time = 30,
                            Difficulty = "Medium",
                            Number_of_likes = 500,
                            Ingredients = "200g spaghetti\r\n150g pancetta or bacon, diced\r\n2 large eggs\r\n50g grated Parmesan cheese\r\n50g grated Pecorino Romano cheese\r\nFreshly ground black pepper",
                            Process = "Cook spaghetti according to package instructions until al dente. Reserve 1/2 cup of pasta water before draining.\r\nIn a separate pan, cook diced pancetta or bacon until crispy.\r\nIn a bowl, whisk together eggs, Parmesan cheese, and Pecorino Romano cheese.\r\nAdd cooked spaghetti to the pan with pancetta/bacon. Remove from heat and quickly toss to coat the pasta.\r\nPour the egg and cheese mixture over the pasta, stirring quickly to combine. The residual heat will cook the eggs and create a creamy sauce. If too dry, add reserved pasta water a little at a time.\r\nSeason with freshly ground black pepper to taste.",
                            Tips_and_Tricks = "Make sure the pan is off the heat when adding the egg and cheese mixture to avoid scrambling the eggs.\r\nUse high-quality Parmesan and Pecorino Romano cheese for the best flavor.\r\nIf you prefer a smoother sauce, you can use only Parmesan cheese instead of a combination of Parmesan and Pecorino Romano."
                        },
                        new Recipes
                        {
                            Name = "Margherita Pizza",
                            Time = 60,
                            Difficulty = " Easy",
                            Number_of_likes = 1000,
                            Ingredients = "1 pre-made pizza dough (store-bought or homemade)\r\n1/2 cup pizza sauce\r\n8 oz fresh mozzarella cheese, sliced\r\nFresh basil leaves, torn\r\nExtra virgin olive oil\r\nSalt and pepper to taste",
                            Process = "Preheat the oven to 475°F (245°C).\r\nRoll out the pizza dough on a floured surface to your desired thickness.\r\nTransfer the rolled-out dough to a pizza stone or baking sheet lined with parchment paper.\r\nSpread the pizza sauce evenly over the dough, leaving a small border around the edges.\r\nArrange the sliced mozzarella cheese over the sauce.\r\nSeason with salt and pepper to taste, then drizzle a little extra virgin olive oil over the top.\r\nTransfer the pizza to the preheated oven and bake for 12-15 minutes, or until the crust is golden brown and the cheese is bubbly and melted.\r\nRemove the pizza from the oven and sprinkle torn fresh basil leaves over the top.\r\nLet the pizza cool slightly before slicing and serving.",
                            Tips_and_Tricks = "For a crispier crust, pre-bake the dough for 5-7 minutes before adding toppings.\r\nUse fresh mozzarella cheese for the best flavor and texture.\r\nIf you prefer, you can add other toppings such as sliced tomatoes, olives, or thinly sliced onions before baking."
                        }
                    );
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred while seeding the database: {ex.Message}");
                    Console.WriteLine($"Inner Exception: {ex.InnerException?.Message}");
                }
            }
        }
    }
}
