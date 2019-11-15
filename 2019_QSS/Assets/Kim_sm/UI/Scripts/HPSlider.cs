using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPSlider : MonoBehaviour
{
    public Image slider;
    public Player plr;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        slider.fillAmount = plr.GetStats()[0] * 0.002f;
        Debug.Log("Slider Fill Amount : " + slider.fillAmount);
    }
}
