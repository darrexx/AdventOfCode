using System.Runtime.InteropServices;

namespace Day2_1
{
    public class KeyPad
    {
        private int position;

        public KeyPad()
        {
            position = 5;
        }

        public int GetPosition()
        {
            return position;
        }

        public void ResetPosition()
        {
            position = 5;
        }

        public KeyPad U()
        {
            if (position == 1 || position == 2 || position == 3)
            {
                return this;
            }
            position -= 3;
            return this;
        }

        public KeyPad R()
        {
            if (position == 3 || position == 6 || position == 9)
            {
                return this;
            }
            position += 1;
            return this;
        }

        public KeyPad D()
        {
            if (position == 7 || position == 8 || position == 9)
            {
                return this;
            }
            position += 3;
            return this;
        }

        public KeyPad L()
        {
            if (position == 1 || position == 4 || position == 7)
            {
                return this;
            }
            position -= 1;
            return this;
        }
    }
}