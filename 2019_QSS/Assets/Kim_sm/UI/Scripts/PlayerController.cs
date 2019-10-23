using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Joystick joystick;
    public float moveSpeed;
    public Animator playerMoveAnimator;

    private Vector3 _moveVector;
    private Transform _transform;

    void Start()
    {
        _transform = transform;
        _moveVector = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        HandleInput();
    }

    private void FixedUpdate()
    {
        PlayerMove();
        playerMoveAnimator.SetBool("IsMove", DistinctionMoving());
    }

    public void HandleInput()
    {
        _moveVector = PoolInput();
    }

    public Vector3 PoolInput()
    {
        float h = joystick.GetHorizontalValue();
        float v = joystick.GetVerticalValue();
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
