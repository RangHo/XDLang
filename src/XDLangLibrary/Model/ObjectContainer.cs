using System;
using System.Collections.Generic;
using System.Text;

namespace RangHo.XDLang.Model
{
    internal class ObjectContainer
    {
        public const int MAXIMUM_VALUE = int.MaxValue;

        public int[] DataStructure { get; private set; }

        public int Pointer { get; private set; }

        /// <summary>
        /// Creates a container with predefined size.
        /// </summary>
        public ObjectContainer()
        {
            this.DataStructure = new int[MAXIMUM_VALUE];
        }

        /// <summary>
        /// Creates a container with custom size.
        /// </summary>
        /// <param name="maxSize">Size of the container</param>
        public ObjectContainer(int maxSize)
        {
            this.DataStructure = new int[maxSize];
        }

        /// <summary>
        /// Gets the value in specific location.
        /// </summary>
        /// <param name="index">Location of the data</param>
        /// <returns>The integer value that in provided location</returns>
        public int this[int index]
        {
            get
            {
                return this.DataStructure[index];
            }
        }

        /// <summary>
        /// Gets the value of current position.
        /// </summary>
        /// <returns>Integer value in current location</returns>
        public int GetValue() => this[Pointer];

        /// <summary>
        /// Gets the value of current location as char.
        /// </summary>
        /// <returns>Character Value in current location</returns>
        public char GetValueAsChar() => (char)this[Pointer];

        /// <summary>
        /// Moves the pointer to the right once.
        /// </summary>
        public void MoveRight() => this.Pointer++;

        /// <summary>
        /// Moves the pointer to the right once.
        /// </summary>
        public void MoveLeft() => this.Pointer--;
    }
}
