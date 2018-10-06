using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PhotonMain : MonoBehaviourPunCallbacks
{

	// Use this for initialization
	void Start()
	{
		PhotonNetwork.ConnectUsingSettings();
	}

	public override void OnConnectedToMaster()
	{
		Debug.Log("接続！");
		// ランダム入室
		PhotonNetwork.JoinRandomRoom();
	}

	public override void OnJoinedRoom()
	{
		Debug.Log("部屋参加");
		float posX = Random.Range(-5, 5);
		Vector3 pos = new Vector3(posX, 0.0f, 0.0f);
		PhotonNetwork.Instantiate("Cube", pos, Quaternion.identity, 0);
	}

	public override void OnJoinRandomFailed(short returnCode, string message)
	{
		Debug.Log("部屋入室失敗");
		PhotonNetwork.CreateRoom(null);
		Debug.Log("部屋作成");
	}
}
