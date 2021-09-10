using System;

namespace Full_GRASP_And_SOLID.Library
{
    //utilice srp ya que console printer solo debería tener la responsabilidad de saber imprimir una receta.
    public class ConsolePrinter
    {
        public static void PrintRecipe(Recipe recipe )
        {
            Console.WriteLine($"Receta de {recipe.FinalProduct.Description}:");
            foreach (Step step in recipe.GetSteps())
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                                  $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
        }
    }
}