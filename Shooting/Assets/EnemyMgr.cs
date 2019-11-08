using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMgr : MonoBehaviour
{
    //키를 누를때마다 enemy 공장에서 enemy생성
    //일정시간이 경과하면 enemy 공장에서 enemy생성
    //->생성시간
    //->경과시간
    float creatTime = 2.0f;
    float currentTime = 0.0f;
    public GameObject enemyFactory;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //일정시간이 경과하면 enemy 공장에서 enemy생성
        currentTime += Time.deltaTime;
        if(currentTime >= creatTime)
        {
            GameObject enemy = Instantiate(enemyFactory);
            enemy.transform.position = transform.position;
            creatTime = Random.Range(1.0f, 3.0f);
            currentTime = 0;
        }

        //if(Input.GetButtonDown("Fire1"))
        //{
        //}
    }
}
