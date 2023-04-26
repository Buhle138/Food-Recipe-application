// See https://aka.ms/new-console-template for more information
using System;
using Ingredients;
using Recipe;

namespace MainFile{
    class Program{
        static void Main(string[] args){
           
         while(true){
              System.Console.Write("Enter The name of the Whole Recipe You're making: ");
               string recipe = Console.ReadLine();
               if(int.TryParse(recipe, out int value)){ //Error handling a case where a user enters a different
                  System.Console.WriteLine("invalid! please enter a word format input here.");
                  continue;
               }
               System.Console.Write("Enter the number of ingredients: ");
               int number = Convert.ToInt32(Console.ReadLine());
               Ingredient[] storage = new Ingredient[number];
           for(int i = 0; i < storage.Length; i++){
                System.Console.Write("Enter name of ingredient: ");
                string ingredientName = Console.ReadLine();
                System.Console.Write("Enter the quantity of the ingredient: ");
                int quantity = Convert.ToInt32(Console.ReadLine());
                System.Console.Write("Enter the unit of measurement: ");
                string unitOfMeasurement = Console.ReadLine();
                System.Console.WriteLine();           
                storage[i] =  new Ingredient(ingredientName, quantity, unitOfMeasurement);
           }
             Method storingObjects = new Method(storage);

             string[] steps = arrayOfSteps();
           
            printingBothIngredientsAndSteps(recipe, storingObjects, steps);

            string userAnswerForScaleFactoring = storingObjects.scaleFactoring();
               
            printingBothIngredientsAndSteps(recipe, storingObjects, steps);

            double factorValue =  storingObjects.gettingTheScaleFactorValue(userAnswerForScaleFactoring);

            setBackOriginalValuesConfirmation(storingObjects, factorValue);

            printingBothIngredientsAndSteps(recipe, storingObjects, steps);

            System.Console.Write("Would you like to clear all data to start a new recipe: ");
            string restartInput = Console.ReadLine();
            restartInput.ToLower();
            if(restartInput.Equals("yes")){
               Array.Clear(storage); //Clearing the array to start a new recipe.
               continue; //Restarting the loop!
            }else{
               break; //stopping the loop from continuing. 
            }

         }
       
        }

        public static string[] arrayOfSteps(){
         System.Console.Write("Enter the number of steps you would like to take: ");
            int numberOfSteps = Convert.ToInt32(Console.ReadLine());
             string[] steps = new string[numberOfSteps];
             for(int i = 0; i < steps.Length; i++){
                System.Console.WriteLine("Step: " + (i + 1));
                steps[i] = Console.ReadLine();
        }
         return steps;
        }


         public static void recipeName(string recipe){
            string upperCaseRecipe = recipe.ToUpper();
            System.Console.WriteLine("----------------------------------------------------");
            System.Console.WriteLine("\t|" + upperCaseRecipe + " " + "RECIPE"+ "|");
            System.Console.WriteLine("----------------------------------------------------");
         }

         public static void printingBothIngredientsAndSteps(string recipe, Method storage, string[] steps){
              recipeName(recipe);
             System.Console.WriteLine("-----------INGREDIENTS------------------------------");
              System.Console.WriteLine(storage);
              System.Console.WriteLine("-----------STEPS-----------------------------------");
             for(int i = 0; i < steps.Length; i++){
                System.Console.WriteLine((i +  1) + ". " + steps[i]);
             }
         }

         public static void setBackOriginalValuesConfirmation(Method storedObject, double factorValue){
            System.Console.Write("Would you like to set back the values to the original values? yes/no  ");
            string userAnswer = Console.ReadLine();
            userAnswer.ToLower();
            if(userAnswer.Equals("yes")){
              storedObject.setQuantitiesBackToOriginalValues(factorValue);
            }
         }
      
      }
   }
