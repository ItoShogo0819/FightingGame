using System.Collections.Generic;

/// <summary>
/// プレイヤーの入力を一定数保持するバッファクラス。過去の入力を遡って参照できるようにするために使用される。
/// </summary>
public class InputBuffer
{
    public IReadOnlyCollection<InputFrame>GetInputFrames() => buffer;

    public InputBuffer(int maxFrames = 30)
    {
        this.maxFrames = maxFrames;
    }

    public void AddInputFrame(InputFrame frame)
    {
        buffer.Enqueue(frame);
        if (buffer.Count > maxFrames)
        {
            buffer.Dequeue();
        }
    }

    private readonly Queue<InputFrame> buffer = new();
    private readonly int maxFrames;
}
