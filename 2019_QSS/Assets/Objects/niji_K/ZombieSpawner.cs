using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    private float time_count = 0;
    public GameObject[] zombie; //생성할 좀비 목록

    //테스트로 wave 10까지만
    private int[] wave_zombie_count = { 0, 5, 10, 25, 50, 10, 20, 40, 60, 70, 20 };
    private int[] wave_spawn_speed = { 0, 5, 5, 5, 5, 8, 5, 5, 5, 5, 8};
    private int[] wave_rest_time = { 0, 5, 5, 5, 5, 15, 10, 10, 10, 10, 30};
    private int wave, zombie_count;
    // Start is called before the first frame update
    void Start()
    {
        wave = 0;
        zombie_count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time_count += Time.deltaTime;

        if (zombie_count == 0) {
            if (time_count > wave_rest_time[wave])
            {
                time_count = 0;
                wave++; zombie_count = wave_zombie_count[wave];
                Debug.Log("Wave: " + wave);
            }
        }
        else
        {
            if (time_count >= wave_spawn_speed[wave])
            {
                Debug.Log(zombie_count);
                float dist = Random.Range(16.0f, 20.0f);
                float angle = Random.Range(-4 * Mathf.PI, 4 * Mathf.PI);
                Vector3 pos = transform.position;
                pos += new Vector3(Mathf.Cos(angle), Mathf.Sin(angle), 0) * dist;
                Instantiate(zombie[Random.Range(0, zombie.Length)], pos, new Quaternion(0, 0, 0, 0)); // 좀비 하나 죽였더니 여기서 에러남
                time_count = 0; zombie_count--;
            }
        }
    }
}
