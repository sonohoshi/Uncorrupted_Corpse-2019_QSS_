using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class InstallTurret : MonoBehaviour
{
    //설치 딜레이
    public float installDelay = 0.0f;

    public GameObject PutDescription;
    public GameObject UIOnOffButton;
    public GameObject CancelButton;

    public Tilemap tilemap;
    //터렛 종류
    public int Turret = 0;

    //터렛 설치
    public GameObject FirstTurret;
    public GameObject SecondTurret;
    public GameObject ThirdTurret;

    private GameObject _Turret;

    //타일 좌표
    Vector2 position;
    void Update()
    {
        if (Turret != 0)
        {
            installDelay += Time.deltaTime;
            if (Input.GetMouseButtonUp(0) == true && installDelay > 1)//설치 딜레이 결정
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit2D hit = Physics2D.Raycast(ray.origin, Vector3.zero);
                tilemap.RefreshAllTiles();
                int x, y;
                x = tilemap.WorldToCell(ray.origin).x;
                y = tilemap.WorldToCell(ray.origin).y;
                position = new Vector2(x * 0.63f, y * 0.63f);//맵만들 때 cell사이즈를 0.63으로 해버렸음 ㅈㅅ;;
                Debug.Log(position);
                if (Turret == 1)
                {
                    _Turret = Instantiate(FirstTurret, position, FirstTurret.transform.rotation);
                }
                else if (Turret == 2)
                {
                    _Turret = Instantiate(SecondTurret, position, SecondTurret.transform.rotation);
                }
                else if (Turret == 3)
                {
                    _Turret = Instantiate(ThirdTurret, position, ThirdTurret.transform.rotation);
                }
                UIOnOffButton.SetActive(true);
                PutDescription.SetActive(false);
                CancelButton.SetActive(false);
                Turret = 0;
                installDelay = 0;
            }
        }
    }
}