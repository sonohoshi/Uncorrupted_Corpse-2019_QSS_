using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class AttackPrepare
{
    public static Attack attack;
    private static Vector3 _vector;

    public static Vector3 PullAttackVector()
    {
        float h = Joystick.Instance.attackHorizontalValue();
        float v = Joystick.Instance.attackVerticalValue();
        _vector = new Vector3(h, v).normalized;
        return _vector;
    }
}
