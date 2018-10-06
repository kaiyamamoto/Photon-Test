using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Cube : MonoBehaviour
{
	[SerializeField]
	private float speed = 3.0f;

	private PhotonView photonView;

	void Start()
	{
		photonView = GetComponent<PhotonView>();
	}

	// Update is called once per frame
	void Update()
	{
		if (photonView.IsMine == false) return;

		if (Input.GetKey(KeyCode.UpArrow))
			transform.position += transform.forward * speed * Time.deltaTime;

		if (Input.GetKey(KeyCode.DownArrow))
			transform.position -= transform.forward * speed * Time.deltaTime;

		if (Input.GetKey(KeyCode.RightArrow))
			transform.position += transform.right * speed * Time.deltaTime;

		if (Input.GetKey(KeyCode.LeftArrow))
			transform.position -= transform.right * speed * Time.deltaTime;
	}
}
