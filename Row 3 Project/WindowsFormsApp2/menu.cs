using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class menu
    {
        
        
        private int quantity;
        private int calories;
        private string foodType;
        
        public int Quantity{
            get{return quantity;}
            set{quantity = value;}
    }
        public int Calories{
        get{return calories;}
        set{calories = value;}
        }
        public string FoodType{
        get{return foodType;}
        set{FoodType = value;}
        }
        
        public menu(){
         quantity = 0;
            calories = 0;
            foodType = '';
        }
        public int calCalories(){
            return len(foodType)*20*quantity;
        }
        public void ResetDisplay(Textbox incomingTextBox){
            incomingTextBox.Clear();   
        }
        public void displayValues(Textbox incomingTextBox, foodType, quantity, calories){
               incomingTextBox.Text = Quantity.ToString() + " " + foodType + " calories:" + calories.ToString();
        }
}
