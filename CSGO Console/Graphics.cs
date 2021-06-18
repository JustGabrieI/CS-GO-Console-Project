using System;
using System.Collections.Generic;
using System.Text;

namespace CS_GO_Console
{
    class Graphics
        { 
               
        public int brightness { get; set; }
        public string graphics { get; set; }
        public string controls { get; set; }

        public Graphics()
        {
            this.brightness = 50;
            this.graphics = "High";
            this.controls = "Default";
        }
        
        public Graphics(int b, string g, string c)
        {
            this.brightness = b;
            this.graphics = g;
            this.controls = c;
        }

        public void BrightnessChange(int add)                  

            {
              brightness += add;
            }

        public void BrightnessRemove(int remove)

        {
            brightness -= remove;
        }


        public override string ToString()
        {
            return "Your graphics are set.";
        }

    }
              
}
