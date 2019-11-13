using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowItemControler : MonoBehaviour
{
    public static float ThrowingTime = 0.0f;

    public ThrowItemJoystick T_I_joystick;
    private bool JustOneTime = true;
    private float moveSpeed = 7.0f;

    private Vector3 _moveVector;
    private Transform _transform;

    public static bool StopThrowingItem = false;
    void Start()
    {
        _transform = transform;
        _moveVector = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        if(ThrowItemJoystick.onClick && JustOneTime)
        {
            HandleInput();
            JustOneTime = false;
            ThrowItemJoystick.inputVector = Vector3.zero;
            ThrowItemJoystick.JoystickImg.rectTransform.anchoredPosition = Vector3.zero;
        }
        if (ThrowingTime <= 1.5f)
        {
            ThrowingTime += Time.deltaTime;
            moveSpeed -= 5.0f * Time.deltaTime;
        }           
        else if (ThrowingTime >= 1.5f)
        {
            ThrowingTime = 0.0f;
            ThrowItemJoystick.onClick = false;
            JustOneTime = true;
        }
    }

    private void FixedUpdate()
    {
        PlayerMove();
    }

    public void HandleInput()
    {
        _moveVector = PoolInput();
    }

    public Vector3 PoolInput()
    {
        float h = T_I_joystick.GetHorizontalValue();
        float v = T_I_joystick.GetVerticalValue();
        Vector3 moveDir = new Vector3(h, v, 0).normalized;

        return moveDir;
    }

    public void PlayerMove()
    {
        _transform.Translate(_moveVector * moveSpeed * Time.deltaTime);
    }
    public bool DistinctionMoving()
    {
        if (_moveVector.x != 0 || _moveVector.y != 0)
            return true;

        return false;
    }
}
