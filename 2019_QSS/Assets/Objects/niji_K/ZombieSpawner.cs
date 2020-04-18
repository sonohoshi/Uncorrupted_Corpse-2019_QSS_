using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    public float time_count = 0;
    public GameObject[] zombie; //생성할 좀비 목록
    public ResultWindow resultWindow;

    //테스트로 wave 10까지만
    private static bool isStarted = false;
    private static bool isEnded = false;
    private static int[] wave_zombie_count = { 0, 20, 20, 25, 50, 60, 70, 80, 90, 100, 150 };
    private static int[] wave_spawn_speed = { 0, 5, 5, 5, 5, 8, 5, 5, 5, 5, 8};
    private static int[] wave_rest_time = { 0, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30};
    public static int wave;
    public static int zombie_count = 0;
    public static bool rest = true;
    
    // Start is called before the first frame update
    void Start()
    {
        wave = 0;
        zombie_count = 0;
    }

    public static void StartGame() => isStarted = true;

    // Update is called once per frame
    void Update()
    {
        if (isStarted)
        {
            if (zombie_count == 0) {
                if (wave == 10 && !isEnded)
                {
                    resultWindow.GameEnd(false);
                    isEnded = true;
                }
                if (FindObjectOfType<Zombie>() == null) {
                    time_count += Time.deltaTime;
                    rest = true;
                }

                if (time_count > wave_rest_time[wave])
                {
                    time_count = 0;
                    wave++; zombie_count = wave_zombie_count[wave];
                    rest = false;
                }
            }
            else
            {
                time_count += Time.deltaTime;
                rest = false;
                if (time_count >= wave_spawn_speed[wave])
                {
                    //float dist = Random.Range(16.0f, 20.0f);
                    //float angle = Random.Range(-4 * Mathf.PI, 4 * Mathf.PI);
                    Vector3 pos = transform.position;
                    //pos += new Vector3(Mathf.Cos(angle), Mathf.Sin(angle), 0) * dist;
                    Instantiate(zombie[Random.Range(0, zombie.Length)], pos, Quaternion.identity);
                    time_count = 0; zombie_count--;
                }
            }
        }
    }
}
