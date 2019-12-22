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
    void Awake()
    {
        nicknameTXT.text = PV.IsMine ? PhotonNetwork.NickName : PV.Owner.NickName;
        nicknameTXT.color = PV.IsMine ? Color.green : Color.red;
    }
}
