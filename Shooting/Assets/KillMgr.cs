using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//죽인 개수를 세는 함수
public class KillMgr : MonoBehaviour
{
    public GameObject KillCntUI;
    int KillCnt;
    public void AddKill()
    {
        KillCnt++;
        Text t = KillCntUI.GetComponent<Text>();
        t.text = "죽인 개수 : " + KillCnt;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
