using System;

namespace Day2_2
{
    public class KeyPad
    {
        private Key position;

        public KeyPad()
        {
            position = Key.K5;
        }

        public override string ToString()
        {
            switch (position)
            {
                case Key.A:
                    return "A";
                case Key.B:
                    return "B";
                case Key.C:
                    return "C";
                case Key.D:
                    return "D";
                case Key.K1:
                    return "1";
                case Key.K2:
                    return "2";
                case Key.K3:
                    return "3";
                case Key.K4:
                    return "4";
                case Key.K5:
                    return "5";
                case Key.K6:
                    return "6";
                case Key.K7:
                    return "7";
                case Key.K8:
                    return "8";
                case Key.K9:
                    return "9";
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public Key GetPosition()
        {
            return position;
        }

        public void ResetPosition()
        {
            position = Key.K5;
        }

        public KeyPad U()
        {
            switch (position)
            {
                case Key.A:
                case Key.B:
                case Key.C:
                    position += 9;
                    break;
                case Key.D:
                    position = Key.B;
                    break;
                case Key.K3:
                    position = Key.K1;
                    break;
                case Key.K6:
                case Key.K7:
                case Key.K8:
                    position -= 4;
                    break;
            }
            return this;

        }

        public KeyPad R()
        {
            switch (position)
            {
                case Key.D:
                case Key.C:
                case Key.K9:
                case Key.K4:
                case Key.K1:
                    break;
                default:
                    position += 1;
                    break;
            }
            return this;
        }

        public KeyPad D()
        {
            switch (position)
            {
                case Key.K1:
                    position = Key.K3;
                    break;
                case Key.K2:
                case Key.K3:
                case Key.K4:
                    position += 4;
                    break;
                case Key.K6:
                case Key.K7:
                case Key.K8:
                    position -= 9;
                    break;
                case Key.B:
                    position = Key.D;
                    break;
            }
            return this;
        }

        public KeyPad L()
        {
            switch (position)
            {
                case Key.D:
                case Key.A:
                case Key.K5:
                case Key.K2:
                case Key.K1:
                    break;
                default:
                    position -= 1;
                    break;
            }
            return this;
        }
    }

    public enum Key
    {
        A = 0,
        B = 1,
        C = 2,
        D = 3,
        K1 = 4,
        K2 = 5,
        K3 = 6,
        K4 = 7,
        K5 = 8,
        K6 = 9,
        K7 = 10,
        K8 = 11,
        K9 = 12

    }
}