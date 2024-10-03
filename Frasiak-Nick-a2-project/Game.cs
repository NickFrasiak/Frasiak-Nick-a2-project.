// Include code libraries you need below (use the namespace).
using System;
using System.Numerics;

// The namespace your code is in.
namespace Game10003
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:
        //colors
        Color skyColor = new Color(0x4d, 0x4d, 0x80);
        Color moonColor1 = new Color(0x44, 0x4a, 0x65);
        
        Color moonColor3 = new Color(0xf9, 0xc2, 0x2b);
        Color moonColor4 = new Color(0Xff, 0Xd6, 0x13);
        Color buildingColor = new Color(0X84, 0X78, 0x75);
        Color buildingLightColor = new Color(0xff, 0xf4, 0x4a);

        //Buildings

        


        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Moon Phases");
            Window.SetSize(400, 400);
           
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(skyColor);
        }
    }
}
