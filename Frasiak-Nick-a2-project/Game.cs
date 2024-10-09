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
        //Array for moon colors to randomize 
        Color[] moonColors;
        Color buildingColor = new Color(0X84, 0X78, 0x75);
        Color buildingLightColor = new Color(0xff, 0xf4, 0x4a);

        //Star coords
        float[] xstarCoords = [];
        float[] ystarCoords = [];
        float starRadius = 2;

        //Moon Shadow
        int shadowxOffset = 180;


        //Current moon color index
        int currentMoonColorIndex = 0;
        bool wasSpacePressed = false;

        //Building coords
        float[][] buildingCoords = [[0, 220], [40, 200], [80, 280], [120, 300], [160, 260], [240, 300], [280, 280], [320, 200], [360, 220]];

        //Window coords
        float[][] windowCoords = [[10, 230], [50, 210], [90, 290], [130, 310], [170, 300], [250, 310], [290, 290], [330, 210], [370, 230]];




        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Color Eclipse");
            Window.SetSize(400, 400);

            moonColors = [moonColourY1, moonColorY2, moonColorB1, moonColorB2, moonColorB3, moonColorW, moonColorP];

            int count = 55;
            xstarCoords = new float[count];
            ystarCoords = new float[count];
            for (int i = 0; i < count; i++)
            {
                xstarCoords[i] = Random.Integer(10, 390);
                ystarCoords[i] = Random.Integer(10, 250);
            }
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(skyColor);
            DrawStars();

            //building color
            Draw.FillColor = buildingColor;
            //Window color
            Draw.FillColor = buildingLightColor;

            DrawBuildings();

            DrawWindows();


            //If spacebar is pressed, Change moon color and change moon shadow offset
            if (Input.IsKeyboardKeyPressed(KeyboardInput.Space))
            {
                if (!wasSpacePressed)
                {
                    currentMoonColorIndex++;
                    shadowxOffset = Random.Integer(70, 210);



                    if (currentMoonColorIndex >= 6)
                    {
                        currentMoonColorIndex = 0;
                    }

                    wasSpacePressed = true;
                }

                else
                {
                    wasSpacePressed = false;
                }
            }
        }




        //stars

        void DrawStars()
        {
            Draw.FillColor = Color.White;
            for (int i = 0; i < xstarCoords.Length; i++)
            {
                Draw.Circle(xstarCoords[i], ystarCoords[i], starRadius);
            }
        }

        //Loop for buildings
        void DrawBuildings()
        {
            Draw.FillColor = buildingColor;

            for (int index = 0; index < buildingCoords.Length; index++)
            {

                if (index != 4)
                {
                    Draw.Rectangle(buildingCoords[index][0], buildingCoords[index][1], 40, 200);

                }

                //Center Building
                Draw.FillColor = buildingColor;
                Draw.Rectangle(160, 260, 80, 260);

            }
        }

        //Loop for windows
        void DrawWindows()
        {

            for (int index = 0; index < windowCoords.Length; index++)
            {
                Draw.FillColor = buildingLightColor;
                Draw.Rectangle(windowCoords[index][0], windowCoords[index][1], 20, 210);

                //Draw 20 rectangles to make window slatts
                for (int i = 0; i < 20; i++)
                {
                    Draw.FillColor = buildingColor;
                    Draw.Rectangle(windowCoords[index][0], windowCoords[index][1] + i * 20, 20, 10);

                    //Draw Vertical window slatts 
                    if (i < 4)
                    {
                        Draw.Rectangle(windowCoords[index][0] + i * 6, windowCoords[index][1], 2, 300);
                    }


                }

            }

            //Center Building Lights
            Draw.FillColor = buildingLightColor;
            Draw.Rectangle(170, 300, 60, 300);

            //Center building window slatts


            //Verticle window slatts

            //clock
            Draw.FillColor = moonColorW;
            Draw.Circle(200, 280, 10);
            //Clock Hands - Clear line color before drawing moon
            Draw.LineColor = Color.Black;
            Draw.LineSize = 3;
            Draw.Line(200, 280, 205, 285);
            Draw.Line(200, 280, 195, 270);
            Draw.LineColor = Color.Clear;


            //Moon!
            Draw.FillColor = moonColors[currentMoonColorIndex];
            Draw.Circle(200, 120, 60);

            Draw.FillColor = skyColor;
            Draw.LineColor = Color.Clear;
            Draw.Circle(shadowxOffset, 120, 60);
            
            //Draw.FillColor = moonColors[1];


            //Cresent moon effect

            //Draw.Circle(180, 120, 60);

        }
    }


}
