using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{    
    public class PrintRecipe
    {
        public static void Printer(Recipe recipe)
        {
            Console.WriteLine(recipe.GetRecipe());
        }
    }
/*Utilicé el patrón SRP para separar las responsabilidades que antes estaban en Recipe
en dos clases, la clase Recipe y la nueva clase PrintRecipe, y así cada clase tiene una sola responsabilidad
}