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
        Color moonColourY1 = new Color(0Xff, 0Xf4, 0X4a);
        Color moonColorY2 = new Color(0xfa, 0xa2, 0x11);
        Color moonColorB1 = new Color(0xa0, 0xde, 0xda);
        Color moonColorB2 = new Color(0x69, 0xa0, 0xc7);
        Color moonColorB3 = new Color(0x30, 0x32, 0x4d);
        Color moonColorW = new Color(0Xff, 0Xf9, 0xf0);
        Color moonColorP = new Color(0x62, 0x1c, 0x80);
        Color buildingColor = new Color(0X84, 0X78, 0x75);
        Color buildingLightColor = new Color(0xff, 0xf4, 0x4a);

        //Buildings
        float[][] buildingCoords = [[0, 220],[40 , 200], [80, 280],[120, 300], [160, 260],[240, 300], [320, 200], [360,200]];

        


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
