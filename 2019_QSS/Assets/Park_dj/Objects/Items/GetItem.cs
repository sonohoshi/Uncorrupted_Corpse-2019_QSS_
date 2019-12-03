using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetItem : MonoBehaviour
{
    public Text GetItemText;

    //재료 획득 시 재료획득 갯수
    public static int GainMaterialItem = 4;
    public static int GainRadioactivityX = 0;

    //업그레이드 된 아이템을 만들 때
    bool MakeUpgradeItem;
    //얻은 아이템을 알려주는 알림창 딜레이
    bool delaytime;
    float time;

    //일반 아이템을 먹을 시에 생기는 램덤값
    int random;

    private void Start()
    {
        delaytime = false;
        GetItemText.text = "빈 탄창을 획득하셨습니다.";
        EmptyCartridge.cnt++;
        StartCoroutine("Get_Item");
    }

    void Update()
    {
        while(GainMaterialItem > 0 && delaytime)
        {
            random = Random.Range(1, 13);
            if(random == 1)
            {
                delaytime = false;
                GetItemText.text = "고철을 획득했습니다.";
                ScrapMetal.cnt++;
                StartCoroutine("Get_Item");
                --GainMaterialItem;
            }
            else if (random == 2)
            {
                delaytime = false;
                GetItemText.text = "화약을 획득했습니다.";
                Gunpowder.cnt++;
                StartCoroutine("Get_Item");
                --GainMaterialItem; 
            }
            else if (random == 3)
            {
                delaytime = false;
                GetItemText.text = "유리를 획득했습니다.";
                Glass.cnt++;
                StartCoroutine("Get_Item");
                --GainMaterialItem;
            }
            else if (random == 4)
            {
                delaytime = false;
                GetItemText.text = "접착제 획득했습니다.";
                Glue.cnt++;
                StartCoroutine("Get_Item");
                --GainMaterialItem;
            }
            else if (random == 5)
            {
                delaytime = false;
                GetItemText.text = "스프링을 획득했습니다.";
                Spring.cnt++;
                StartCoroutine("Get_Item");
                --GainMaterialItem;
            }
            else if (random == 6)
            {
                delaytime = false;
                GetItemText.text = "와이어를 획득했습니다.";
                Wire.cnt++;
                StartCoroutine("Get_Item");
                --GainMaterialItem;
            }
            else if (random == 7)
            {
                delaytime = false;
                GetItemText.text = "나뭇가지를 획득했습니다.";
                Branch.cnt++;
                StartCoroutine("Get_Item");
                --GainMaterialItem;
            }
            else if (random == 8)
            {
                delaytime = false;
                GetItemText.text = "못을 획득했습니다.";
                Nail.cnt++;
                StartCoroutine("Get_Item");
                --GainMaterialItem;
            }
            else if (random == 9)
            {
                delaytime = false;
                GetItemText.text = "라이터를 획득했습니다.";
                Lighter.cnt++;
                StartCoroutine("Get_Item");
                --GainMaterialItem;
            }
            else if (random == 10)
            {
                delaytime = false;
                GetItemText.text = "천을 획득했습니다.";
                Fabric.cnt++;
                StartCoroutine("Get_Item");
                --GainMaterialItem;
            }
            else if (random == 11)
            {
                delaytime = false;
                GetItemText.text = "실을 획득했습니다.";
                Thread.cnt++;
                StartCoroutine("Get_Item");
                --GainMaterialItem;
            }
            else if(random == 12)
            {
                delaytime = false;
                GetItemText.text = "은을 획득했습니다.";
                Silver.cnt++;
                StartCoroutine("Get_Item");
                --GainMaterialItem;
            }
            else if (random == 13)
            {
                delaytime = false;
                GetItemText.text = "레이저 포인터를 획득했습니다.";
                LaserPointer.cnt++;
                StartCoroutine("Get_Item");
                --GainMaterialItem;                                     
            }
        }
        while (GainRadioactivityX > 0 && delaytime)
        {
            delaytime = false;
            GetItemText.text = "방사능X를 획득했습니다.";
            RadioactivityX.cnt++;
            StartCoroutine("Get_Item");
            --GainMaterialItem;
        }// 여기까지 재료아이템 얻는 스크립트
        if (MakeItemButton.MakeOnetimeWeapon != 0 || MakeItemButton.MakeUpgradeWeapon != 0)
        {
            MakeUpgradeItem = true;
        }
        while (MakeUpgradeItem && delaytime)
        {
             delaytime = false;
             MakeUpgradeItem = false;
            if (MakeItemButton.MakeOnetimeWeapon == 1)
            {
               GetItemText.text = "탄환 제작 성공!";
               MakeItemButton.MakeOnetimeWeapon = 0;
            }
            else if (MakeItemButton.MakeOnetimeWeapon == 2)
            {
                GetItemText.text = "은 탄환 제작 성공!";
                MakeItemButton.MakeOnetimeWeapon = 0;
            }
            else if (MakeItemButton.MakeOnetimeWeapon == 3)
            {
                GetItemText.text = "볼트 제작 성공!";
                MakeItemButton.MakeOnetimeWeapon = 0;
            }
            else if (MakeItemButton.MakeOnetimeWeapon == 4)
            {
                GetItemText.text = "은 볼트 제작 성공!";
                MakeItemButton.MakeOnetimeWeapon = 0;
            }
            else if (MakeItemButton.MakeOnetimeWeapon == 5)
            {
                GetItemText.text = "수류탄 제작 성공!";
                MakeItemButton.MakeOnetimeWeapon = 0;
            }
            else if (MakeItemButton.MakeOnetimeWeapon == 6)
            {
                GetItemText.text = "파편 지뢰 제작 성공!";
                MakeItemButton.MakeOnetimeWeapon = 0;
            }
            else if (MakeItemButton.MakeOnetimeWeapon == 7)
            {
                GetItemText.text = "화염병 제작 성공!";
                MakeItemButton.MakeOnetimeWeapon = 0;
            }
            else if (MakeItemButton.MakeOnetimeWeapon == 8)
            {
                GetItemText.text = "도트 사이트 제작 성공!";
                MakeItemButton.MakeOnetimeWeapon = 0;
            }
            else if (MakeItemButton.MakeUpgradeWeapon == 1)
            {
                GetItemText.text = "강화 배트 제작 성공!\n이 게임 동안 강화배트를 추가로 제작할 수 없습니다.";
                MakeItemButton.MakeUpgradeWeapon = 0;
            }
            else if (MakeItemButton.MakeUpgradeWeapon == 2)
            {
                GetItemText.text = "광선검 제작 성공!\n이 게임 동안 광선검을 추가로 제작할 수 없습니다.";
                MakeItemButton.MakeUpgradeWeapon = 0;
            }
            else if (MakeItemButton.MakeUpgradeWeapon == 3)
            {
                GetItemText.text = "강화 쇠뇌 제작 성공!\n이 게임 동안 강화 쇠뇌를 추가로 제작할 수 없습니다.";
                MakeItemButton.MakeUpgradeWeapon = 0;
            }
            else if (MakeItemButton.MakeUpgradeWeapon == 4)
            {
                GetItemText.text = "붕괴 쇠뇌 제작 성공!\n이 게임 동안 붕괴 쇠뇌를 추가로 제작할 수 없습니다.";
                MakeItemButton.MakeUpgradeWeapon = 0;
            }
            else if (MakeItemButton.MakeUpgradeWeapon == 5)
            {
                GetItemText.text = "레이저 돌격 소총 제작 성공!\n이 게임 동안 레이저 돌격 소총 추가로 제작할 수 없습니다.";
                MakeItemButton.MakeUpgradeWeapon = 0;
            }
            else if (MakeItemButton.MakeUpgradeWeapon == 6)
            {
                GetItemText.text = "레이저 권총 제작 성공!\n이 게임 동안 레이저 권총을 추가로 제작할 수 없습니다.";
                MakeItemButton.MakeUpgradeWeapon = 0;
            }
            else if (MakeItemButton.MakeUpgradeWeapon == 7)
            {
                GetItemText.text = "붕괴 산탄총 제작 성공!\n이 게임 동안 붕괴 산탄총을 추가로 제작할 수 없습니다.";
                MakeItemButton.MakeUpgradeWeapon = 0;
            }
            else if (MakeItemButton.MakeArmor == 1)
            {
                GetItemText.text = "옷 제작 성공!";
                MakeItemButton.MakeUpgradeWeapon = 0;
            }
            else if (MakeItemButton.MakeArmor == 2)
            {
                GetItemText.text = "갑옷 제작 성공!";
                MakeItemButton.MakeUpgradeWeapon = 0;
            }
            else if (MakeItemButton.MakeArmor == 3)
            {
                GetItemText.text = "은 갑옷 제작 성공!";
                MakeItemButton.MakeUpgradeWeapon = 0;
            }
            StartCoroutine("Get_Item");
        }//아이템을 제작하는 스크립트
    }

    IEnumerator Get_Item()
    {
        time = 0.0f;
        while (time < 0.5f)
        {
            yield return new WaitForSeconds(0.02f);
            gameObject.transform.position += new Vector3(0, 100f, 0) * Time.deltaTime;
            time += Time.deltaTime;
        }
        time = 0.0f;
        yield return new WaitForSeconds(3.0f);
        while (time < 0.5f)
        {
            yield return new WaitForSeconds(0.02f);
            gameObject.transform.position += new Vector3(0, -100f, 0) * Time.deltaTime;
            time += Time.deltaTime;
        }
        yield return new WaitForSeconds(2.0f);
        delaytime = true;
    }//표기 딜레이 스크립트
}
