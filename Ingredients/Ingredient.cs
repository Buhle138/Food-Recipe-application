using System;

namespace Ingredients{
    public class Ingredient{

    private string name;
    private double quantity;
    private string unitOfMeasurement;
    private string  nameOfRecipe;                                      
   public Ingredient(string name, int quantity, string unitOfMeasurement){
        this.name = name;
        this.quantity = quantity;
        this.unitOfMeasurement = unitOfMeasurement;
    }

    public Ingredient(Ingredient source){
        this.name = source.name;
        this.quantity = source.quantity;
        this.unitOfMeasurement = source.unitOfMeasurement;
    }

    public String getNameOfRecipe(){
        return this.nameOfRecipe;
    }

    public String getName(){
        return this.name;
    }

    

    public double getQuantity(){
        return this.quantity;
    }

    public void setQuantity(double quantity){
       this.quantity = quantity;
    }

    public void scaleFactor(double scale){
        double newQuantity = this.quantity * scale;
        setQuantity(newQuantity);
    }

   

    public string getUnitOfMeasurement(){
        return this.unitOfMeasurement;
    }

    public override string ToString(){
        return  "* " +  this.quantity  + " " + this.unitOfMeasurement + " " + this.name + "\r\n";
    }
       
    }
}