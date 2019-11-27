using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowItemFactory : MonoBehaviour
{
    public GameObject ThrowItem;
    public GameObject ThrowingSpace;

    private bool delayTime = true;
    private float _delayTime = 1.6f;
    // Update is called once per frame
    void Update()
    {

        if(ThrowItemJoystick._onclick == true && delayTime )
        {
            _delayTime = 0.0f;
            GameObject _ThrowItem = Instantiate(ThrowItem, ThrowingSpace.transform.position, ThrowingSpace.transform.rotation);
            ThrowItemJoystick._onclick = false;
            Destroy(_ThrowItem, 1.51f);
        }
        if (_delayTime >= 1.51)
        {
            delayTime = true;           
        }
        else
        {
            ThrowItemJoystick._onclick = false;
            delayTime = false;
            _delayTime += Time.deltaTime;
        }
    }
}
