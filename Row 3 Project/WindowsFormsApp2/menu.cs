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
      
        //calorie values
        public int c_hamBun;
        public int c_burger;
        public int c_lettuce;
        public int c_htDog;
        public int c_htDogBun;
        public int c_fries;
        public int c_mustard;
        public int c_ketchup;
       
        // price values
        public int p_hamBun;
        public int c_burger;
        public int c_lettuce;
        public int c_htDog;
        public int c_;htDogBun;
        public int c_fries;
        public int c_mustard;
        public int c_ketchup;

        
        public int Quantity{
            get{return quantity;}
            set{quantity = value;}
        }
        public int Calories{
        get{return calories;}
        set{calories = value;}
        }
        public int Price{
        get{return price;}
        set{price = value;}
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
        
    }
}
