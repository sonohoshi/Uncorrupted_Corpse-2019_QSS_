using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AttackCancle : MonoBehaviour
{
    public GameObject CancleButton;
    private Vector2 ButtonPosition;
    private Vector2 mouseInput;

    public static bool Cancel;
    public static bool Delayused = false;
    private void Start()
    {
        ButtonPosition.x = CancleButton.transform.position.x - 692.8f;
        ButtonPosition.y = CancleButton.transform.position.y - 171;
    }

    private void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            mouseInput = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        if ((mouseInput.x >= ButtonPosition.x - 1) && (mouseInput.x <= ButtonPosition.x + 1) &&
            (mouseInput.y >= ButtonPosition.y - 1) && (mouseInput.y <= ButtonPosition.y + 1))
        {
            ThrowItemJoystick.inputVector = Vector3.zero;
            ThrowItemJoystick.JoystickImg.rectTransform.anchoredPosition = Vector3.zero;
            Cancel = true;
        }
        else if(Delayused == false)
        {
            StartCoroutine("AttackDelay");            
        }
    }

    IEnumerable AttackDelay()
    {
        Delayused = true;
        Cancel = false;
        yield return new WaitForSeconds(1.0f);
        Cancel = true;
    }
}
