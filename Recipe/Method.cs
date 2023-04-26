using System;
using Ingredients;
using System.Collections;

namespace Recipe{
    public class Method{
     Ingredient[] ingredients;

     //Creating  a method of storing these ingredients

     public Method(Ingredient[] ingredient){
        this.ingredients = new Ingredient[ingredient.Length];
        for(int i = 0; i < ingredient.Length; i++){
             this.ingredients[i] = new Ingredient(ingredient[i]);
        }
     }

    //Making this scaleFactor method return scale factor value so I can use it on setting back the quantities back to the original.
    public string scaleFactoring(){
          System.Console.Write("Would you like to enter the scale factor to add more enter? enter (yes/no):  ");
            string userAnswer = Console.ReadLine();
            if(userAnswer.Equals("yes")){
               System.Console.Write("Choose a scale factor to increase quantity of ingredients between 0.5 (half), 2(double) and 3(triple): ");
               string scalefactorInput = Console.ReadLine();
               scalefactorInput.ToLower();
               for(int i = 0; i < this.ingredients.Length; i++){
                  switch(scalefactorInput){
                     case "half":  this.ingredients[i].scaleFactor(0.5); break;
                     case "double":  this.ingredients[i].scaleFactor(2);break;
                     case "triple":  this.ingredients[i].scaleFactor(3);break;
                     case "0.5":  this.ingredients[i].scaleFactor(0.5);break;
                     case "2":  this.ingredients[i].scaleFactor(2);break;
                     case "3":  this.ingredients[i].scaleFactor(3);break;
                     default : return "wrong input";
                  }
               }
                return scalefactorInput;
            }else{
                return "wrong input";
            }
             
           
    }

    public double gettingTheScaleFactorValue(string factorValue){
        switch(factorValue){
            case "half": return 0.5;
            case "double" : return 2;
            case "triple" : return 3;
            case "0.5": return 0.5;
            case "2": return 2.0;
            case "3": return 3.0;
            case "wrong input": return 1.0;
        }
        return 1.0;
    }


    public void setQuantitiesBackToOriginalValues(double factorValue){
        for(int i = 0; i < this.ingredients.Length; i++){
            this.ingredients[i].setQuantity(this.ingredients[i].getQuantity() / factorValue);
        }
    }

      public override string ToString(){
        string temp = "";
        for(int i = 0; i < this.ingredients.Length; i++){
            temp += this.ingredients[i].ToString();
        }
        return temp;
     }
    }
}