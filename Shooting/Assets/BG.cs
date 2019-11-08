using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG : MonoBehaviour
{
    //배경을 일정한 속도로 움직이고 싶다.

    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //메쉬렌더러->메테리얼->오프셋
        MeshRenderer mr = GetComponent<MeshRenderer>();
        Material mat = mr.material;
        mat.mainTextureOffset += Vector2.up * 1 * Time.deltaTime;
    }
}
