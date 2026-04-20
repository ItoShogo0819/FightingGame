using UnityEngine;

public struct InputFrame
{
    // プレイヤーの入力を表す構造体。1フレーム分の入力を保持する。
    public Vector2 Direction;

    // 攻撃ボタンが押されたかどうかを表すフラグ。1フレームのみ有効。
    public bool AttackPressed;

    // この入力が何フレーム目のものかを示すカウンタ。デバッグやリプレイ機能などで使用する。
    public int FrameCount;
}
