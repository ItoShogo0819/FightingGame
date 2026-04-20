using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// InputSystemを使用して、プレイヤーの入力を読み取るクラス。
/// </summary>
public class InputReader : MonoBehaviour
{
    public Vector2 Move { get; private set; }
    public bool AttackPressed { get; private set; }

    public void OnMove(InputAction.CallbackContext ctx)
    {
        Move = ctx.ReadValue<Vector2>();
    }

    public void OnAttack(InputAction.CallbackContext ctx)
    {
        if (ctx.performed) AttackPressed = true;
    }

    private void LateUpdate()
    {
        // 1フレームのみ有効にするため、攻撃入力をリセット
        AttackPressed = false;
    }
}
