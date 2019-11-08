using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerFire : MonoBehaviour
{
    //총알을 총알공장에서 찍어낸다
    public GameObject bulletFactory;

    //총알 갯수를 센 다음 텍스트로 표시해 둔다
    int fireCnt;
    float currentTime;
    public Text fireCntUI;
    void Update()
    {
        currentTime += Time.deltaTime;
        //키를 누르면 총알이 발사된다.
        //if(Input.GetButtonDown("Fire1"))
        if(currentTime > 0.5)
        {
            //총알을 공장에서 찍어냄
            GameObject bullet = Instantiate(bulletFactory);
            bullet.transform.position = transform.position;
            fireCnt++;
            fireCntUI.text = "발사 개수 : " + fireCnt.ToString();
            currentTime = 0.0f;
        }
    }
}
