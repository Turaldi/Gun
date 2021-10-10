using System;
using System.Collections.Generic;
using System.Text;

namespace Gun_Task
{
   public  class Gun
    {
        public string GunName;
        public int AmmoCount;
        public int  AmmoLimit;
        public int fullAmmo ;


        public Gun()
        {

        }
        public Gun(string GunName)
        {
            if (GunName == "Aug")
            {
                this.GunName = GunName;
                 AmmoCount= 30;
                 AmmoLimit = 30;
                 fullAmmo = 180;

            }
            else if (GunName=="Groza")
            {
                this.GunName = GunName;
                AmmoCount = 30;
                AmmoCount = 30;
                fullAmmo = 180;
            }
            Console.WriteLine("please enter any weapon name");

        }

        public void Reload(int say)
        {
            if (AmmoCount==0)
            {
                AmmoCount = AmmoLimit;
                fullAmmo -= AmmoLimit;
                Console.WriteLine("Successfully changed ammo");
            }
            else
            {
                Console.WriteLine("please refill after ammo run out");
            }
        }







































































        
    }
      
    
}
