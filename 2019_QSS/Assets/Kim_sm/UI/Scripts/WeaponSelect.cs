using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSelect : MonoBehaviour
{
    public GameObject bundle;
    public GameObject player;
    public GameObject dummyBTN;
    public Attack atk;
    public void SelectWeapon(int n)
    {
        switch (n)
        {
            case 0:
                player.transform.GetChild(0).gameObject.SetActive(true);
                break;
            case 1:
                player.transform.GetChild(1).gameObject.SetActive(true);
                break;
            case 2:
                player.transform.GetChild(2).gameObject.SetActive(true);
                break;
            case 3:
                player.transform.GetChild(3).gameObject.SetActive(true);
                break;
        }

        bundle.SetActive(false);
        dummyBTN.SetActive(false);
        ZombieSpawner.StartGame();
        atk.Selector();
    }
}
