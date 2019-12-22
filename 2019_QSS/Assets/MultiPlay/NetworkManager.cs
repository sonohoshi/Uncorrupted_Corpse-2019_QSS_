using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;
using UnityEngine.UI;

public class NetworkManager : MonoBehaviourPunCallbacks
{
    //public Text statusText;
    public InputField nicknameInput;
    public Button failedBTN;
    public SceneChanger SC;

    private int weaponType;

    //void Update() => statusText.text = PhotonNetwork.NetworkClientState.ToString();

    public void Connect(int n)
    {
        PhotonNetwork.ConnectUsingSettings();
        weaponType = n;
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("Server Login success");
        PhotonNetwork.LocalPlayer.NickName = nicknameInput.text;
        JoinOrCreateRoom();
    }

    public void Disconnect() => PhotonNetwork.Disconnect();

    public override void OnDisconnected(DisconnectCause cause) => Debug.Log("Disconnected");

    public void JoinLobby() => PhotonNetwork.JoinLobby();

    public override void OnJoinedLobby() => Debug.Log("Lobby Login success");

    public void JoinOrCreateRoom()
    {
        PhotonNetwork.JoinOrCreateRoom("Room", new RoomOptions {MaxPlayers = 4}, null);
    }

    public void JoinRandomRoom() => PhotonNetwork.JoinRandomRoom();

    public void LeaveRoom() => PhotonNetwork.LeaveRoom();

    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        failedBTN.gameObject.SetActive(true);
    }
    public override void OnJoinRoomFailed(short returnCode, string message)
    { 
        failedBTN.gameObject.SetActive(true);
    }
    public override void OnJoinRandomFailed(short returnCode, string message) => Debug.Log("Random Join room Failed");

    public override void OnJoinedRoom()
    {
        SC.GameStart();
        GameObject player = PhotonNetwork.Instantiate("Player1", Vector3.forward, Quaternion.identity);
        player.GetComponent<NetworkPlayer>().SetWeapon(weaponType);
    }
}
