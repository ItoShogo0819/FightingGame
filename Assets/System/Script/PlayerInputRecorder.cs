using UnityEngine;

public class PlayerInputRecorder : MonoBehaviour
{
    public InputBuffer GetBuffer() => _inputBuffer;

    [SerializeField] private InputReader _inputReader;

    private InputBuffer _inputBuffer;

    private void Awake()
    {
        _inputBuffer = new InputBuffer(30);
    }

    private void FixedUpdate()
    {
        
    }

    private void Record()
    {
        var frame = new InputFrame
        {
            Direction = _inputReader.Move,
            AttackPressed = _inputReader.AttackPressed,
            FrameCount = FrameCount.CurrentFrame
        };

        _inputBuffer.AddInputFrame(frame);
    }
}
