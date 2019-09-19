using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetItem : MonoBehaviour
{
    public Text GetItemText;

    public static int GainMaterialItem = 2;
    public static int GainOneTimeWeaponlItem = 0;
    public static int GainArmorItem = 0;
    public static int GainWeaponItem = 0;

    bool delaytime = true;
    float time;

    int random;
    void Update()
    {
        while(GainMaterialItem > 0 && delaytime)
        {
            random = Random.Range(1, 15);
            if(random == 1)
            {
                delaytime = false;
                GetItemText.text = "고철을 획득하셨습니다.";
                ScrapMetal.cnt++;
                StartCoroutine("Get_Item");
                --GainMaterialItem;
            }
            else if (random == 2)
            {
                delaytime = false;
                GetItemText.text = "화약을 획득하셨습니다.";
                Gunpowder.cnt++;
                StartCoroutine("Get_Item");
                --GainMaterialItem; 
            }
            else if (random == 3)
            {
                delaytime = false;
                GetItemText.text = "유리를 획득하셨습니다.";
                Glass.cnt++;
                StartCoroutine("Get_Item");
                --GainMaterialItem;
            }
            else if (random == 4)
            {
                delaytime = false;
                GetItemText.text = "접착제 획득하셨습니다.";
                Glue.cnt++;
                StartCoroutine("Get_Item");
                --GainMaterialItem;
            }
            else if (random == 5)
            {
                delaytime = false;
                GetItemText.text = "스프링을 획득하셨습니다.";
                Spring.cnt++;
                StartCoroutine("Get_Item");
                --GainMaterialItem;
            }
            else if (random == 6)
            {
                delaytime = false;
                GetItemText.text = "와이어를 획득하셨습니다.";
                Wire.cnt++;
                StartCoroutine("Get_Item");
                --GainMaterialItem;
            }
            else if (random == 7)
            {
                delaytime = false;
                GetItemText.text = "빈 탄창을 획득하셨습니다.";
                EmptyCartridge.cnt++;
                StartCoroutine("Get_Item");
                --GainMaterialItem;
            }
            else if (random == 8)
            {
                delaytime = false;
                GetItemText.text = "나뭇가지를 획득하셨습니다.";
                Branch.cnt++;
                StartCoroutine("Get_Item");
                --GainMaterialItem;
            }
            else if (random == 9)
            {
                delaytime = false;
                GetItemText.text = "못을 획득하셨습니다.";
                Nail.cnt++;
                StartCoroutine("Get_Item");
                --GainMaterialItem;
            }
            else if (random == 10)
            {
                delaytime = false;
                GetItemText.text = "라이터를 획득하셨습니다.";
                Lighter.cnt++;
                StartCoroutine("Get_Item");
                --GainMaterialItem;
            }
            else if (random == 11)
            {
                delaytime = false;
                GetItemText.text = "천을 획득하셨습니다.";
                Fabric.cnt++;
                StartCoroutine("Get_Item");
                --GainMaterialItem;
            }
            else if (random == 12)
            {
                delaytime = false;
                GetItemText.text = "실을 획득하셨습니다.";
                Thread.cnt++;
                StartCoroutine("Get_Item");
                --GainMaterialItem;
            }
            else if(random == 13)
            {
                delaytime = false;
                GetItemText.text = "은을 획득하셨습니다.";
                Silver.cnt++;
                StartCoroutine("Get_Item");
                --GainMaterialItem;
            }
            else if (random == 14)
            {
                delaytime = false;
                GetItemText.text = "레이저 포인터를 획득하셨습니다.";
                LaserPointer.cnt++;
                StartCoroutine("Get_Item");
                --GainMaterialItem;
            }
            else if (random == 15)
            {
                delaytime = false;
                GetItemText.text = "방사능X를 획득하셨습니다.";
                RadioactivityX.cnt++;
                StartCoroutine("Get_Item");
                --GainMaterialItem;
            }
        }
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
    }
}
