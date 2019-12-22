using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;
public class NetworkPlayer : MonoBehaviour
{
    public Text nicknameTXT;
    public PhotonView PV;
    public Attack ATK;
    void Awake()
    {
        nicknameTXT.text = PV.IsMine ? PhotonNetwork.NickName : PV.Owner.NickName;
        nicknameTXT.color = PV.IsMine ? Color.green : Color.red;
        ATK.PlayerInitialize(this.gameObject);
    }

    public void SetWeapon(int weaponType)
    {
        if (weaponType == 0) this.transform.GetChild(0).gameObject.SetActive(true);
        else if(weaponType == 1) this.transform.GetChild(2).gameObject.SetActive(true);
        else if(weaponType == 2) this.transform.GetChild(3).gameObject.SetActive(true);
        else if(weaponType == 3) this.transform.GetChild(4).gameObject.SetActive(true);
    }
}
