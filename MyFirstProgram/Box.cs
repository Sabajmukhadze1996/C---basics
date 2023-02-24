using System;

namespace Properties
{
    class Box
    {
        private int width;
        private int height;
        private int length;
        private int volume;

        // Constructor with Width, Height and Length parameters
        public Box(int width, int height, int length)
        {
            this.width = width;
            this.height = height;
            this.length = length;
            this.volume = width * height * length;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Length is {0} and height is {1} and width is {2} so the volume is {3}", width, height, length, volume);
        }
    }
}
