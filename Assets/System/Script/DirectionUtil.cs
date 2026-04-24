using UnityEngine;

public static class DirectionUtil
{
    public static NumpadDirection ToNumpad(Vector2 input, bool isFacingRight = true)
    {
        float adjustedX = isFacingRight ? input.x : -input.x;
        float t = 0.5f;

        int x = input.x > t ? 1 : input.x < -t ? -1 : 0;
        int y = input.y > t ? 1 : input.y < -t ? -1 : 0;

        return (x, y) switch
        {
            (0, 0) => NumpadDirection.Neutral,
            (0, 1) => NumpadDirection.Up,
            (0, -1) => NumpadDirection.Down,
            (1, 0) => NumpadDirection.Right,
            (-1, 0) => NumpadDirection.Left,
            (1, 1) => NumpadDirection.UpRight,
            (-1, 1) => NumpadDirection.UpLeft,
            (1, -1) => NumpadDirection.DownRight,
            (-1, -1) => NumpadDirection.DownLeft,
            _ => NumpadDirection.Neutral
        };
    }
}
