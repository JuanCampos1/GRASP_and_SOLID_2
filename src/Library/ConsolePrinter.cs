using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter
    {
        /*Por srp se crea una clase ConsolePrineter para que Recipe no tenga la responsabilidad de calcular el
        coste total y de imprimirse a si misma*/
        public void PrintRecipe(Recipe recipe)
        {
            Console.WriteLine($"Receta de {recipe.FinalProduct.Description}:");
            foreach (Step step in recipe.step)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
            Console.WriteLine("Coste total: " + recipe.GetProductionCost());
        }
    }
}