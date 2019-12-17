using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveUI : MonoBehaviour
{
    private Text info;
    // Start is called before the first frame update
    void Start()
    {
        info = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        int zombies = FindObjectsOfType<Zombie>().Length;
        if (ZombieSpawner.rest) info.text = "Intermission";
        else info.text = "Wave: " + ZombieSpawner.wave + "\nZombie(s) left: " + zombies;
    }
}
