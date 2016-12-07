using System;

namespace Day1
{
    public enum FacingDirection
    {
        North,
        South,
        East,
        West
    }

    public static class FacingDirectionExtension
    {
        public static FacingDirection L(this FacingDirection direction)
        {
            switch (direction)
            {
                case FacingDirection.East:
                    return FacingDirection.North;
                case FacingDirection.North:
                    return FacingDirection.West;
                case FacingDirection.West:
                    return FacingDirection.South;
                case FacingDirection.South:
                    return FacingDirection.East;
                default:
                    throw new ArgumentOutOfRangeException(nameof(direction), direction, null);
            }
        }

        public static FacingDirection R(this FacingDirection direction)
        {
            switch (direction)
            {
                case FacingDirection.East:
                    return FacingDirection.South;
                case FacingDirection.North:
                    return FacingDirection.East;
                case FacingDirection.West:
                    return FacingDirection.North;
                case FacingDirection.South:
                    return FacingDirection.West;
                default:
                    throw new ArgumentOutOfRangeException(nameof(direction), direction, null);
            }
        }
    }
}