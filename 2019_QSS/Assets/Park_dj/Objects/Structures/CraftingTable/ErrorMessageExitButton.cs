using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ErrorMessageExitButton : MonoBehaviour
{
    public GameObject ErrorMessageUI;
    public void ExitErrorMessage()
    {
        MakeItemButton.ErrorMessageUIisOnOff = false;
        ErrorMessageUI.SetActive(false);
    }
}
