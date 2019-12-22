using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailButton : MonoBehaviour
{
    void Awake()
    {
        this.gameObject.SetActive(false);
    }
    
    public void ExitButton()
    {
        this.gameObject.SetActive(false);
    }
}
