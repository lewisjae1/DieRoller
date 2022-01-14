using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieRoller
{
    /// <summary>
    /// Represents a single six sided die (1-6)
    /// </summary>
    public class Die
    {
        /// <summary>
        /// Creates the die and rolls it to start with
        /// a random number1
        /// </summary>
        public Die()
        {
            Roll();
        }
        /// <summary>
        /// The current face up value of the die
        /// </summary>
        public byte FaceValue { get; private set; }
        
        /// <summary>
        /// True if the die is currently held
        /// </summary>
        public bool IsHeld { get; set; }

        /// <summary>
        /// Rolls the die and sets the <see cref="FaceValue"/>
        /// to the new nubmer if the die is not currently held. 
        /// Returns the new <see cref="FaceValue"/>
        /// </summary>
        /// <returns>Returns the new <see cref="FaceValue"/></returns>
        public byte Roll()
        {
            if (!IsHeld)
            {
                // Generate random number
                Random random = new();
                byte newValue = (byte)random.Next(1, 7);

                FaceValue = newValue;
            }
            

            return FaceValue;
        }
    }
}
