using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{    
    public class PrintRecipe
    {
        /*public static Recipe item;
        public PrintRecipe(Recipe recipe)
        /*{
            this.item = recipe;
        }
        
        Console.WriteLine($"Receta de {Recipe.FinalProduct.Description}:");
        foreach (Step step in Recipe.steps)
        {
            Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                $"usando '{step.Equipment.Description}' durante {step.Time}");
        }
    }*/
        public static void Printer(Recipe recipe)
        {
            Console.WriteLine(recipe.GetRecipe());
        }
    }

}