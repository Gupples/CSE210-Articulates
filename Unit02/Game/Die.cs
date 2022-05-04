using System;


namespace Unit02.Game
{
    // TODO: Implement the Die class as follows...
    // 1) Add the class declaration. Use the following class comment.

        /// <summary>
        /// A small cube with a different number of spots on each of its six sides.
        /// 
        /// The responsibility of Die is to keep track of its currently rolled value and the points its
        /// worth.
        /// </summary> 
        public class Die
        {
            public int value;
            public int points;




    // 2) Create the class constructor. Use the following method comment.

        /// <summary>
        /// Constructs a new instance of Die.
        /// </summary>
            public Die()
            {
                value = 0;
                points = -1;
            } // exit Die constructor.

    
    // 3) Create the Roll() method. Use the following method comment.
        
        /// <summary>
        /// Generates a new random value and calculates the points for the die. Fives are 
        /// worth 50 points, ones are worth 100 points, everything else is worth 0 points.
        /// </summary>
            public void Roll()
            {
                Random random = new Random();
                int rNum = random.Next(1, 7);
                // Thanks to docs.microsoft for teaching me how to
                // make a random number generator.
                value = rNum;
                if (value == 5)
                {
                    points = 50;
                }
                else if (value == 1)
                {
                    points = 100;
                }
                else
                {
                    points = 0;
                }
            }
        
        } // exit Die class
}