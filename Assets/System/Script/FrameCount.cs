using UnityEngine;

public class FrameCount : MonoBehaviour
{
    public static int CurrentFrame { get; private set; }

    private void FixedUpdate()
    {
        CurrentFrame++;
    }
}
