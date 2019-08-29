using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackBTN : MonoBehaviour
{
    public Joystick joystick;
    public Attack attack;
    public Button button;
    private Vector3 _attackVector;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        button.onClick.AddListener(PullAttackVector);
    }

    void PullAttackVector()
    {
        float h = joystick.attackHorizontalValue();
        float v = joystick.attackVerticalValue();
        _attackVector = new Vector3(h, v, 0).normalized;
        
    }
}
