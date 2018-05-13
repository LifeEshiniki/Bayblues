using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
	public float speed = 50;
	private Vector3 Player_pos;
	public Vector3 direction;
	public float varticalMove;
	float horizontal; 
	float vertical;
	float angle;
	// Use this for initialization
	void Start () {
		Player_pos = GetComponent<Transform>().position;
	}
	// Update is called once per frame
	void Update () {
		horizontal = Input.GetAxis("Horizontal");
		vertical = Input.GetAxis("Vertical");
		Vector3 Pos = this.gameObject.transform.position;
		this.gameObject.transform.position = (new Vector3 (Pos.x,(float)(Terrain.activeTerrain.SampleHeight(transform.position) + 2.0), Pos.z));
		
		transform.Translate(Quaternion.AngleAxis(angle, Vector3.up) * new Vector3(horizontal, 0, vertical));
		//transform.rotation = Quaternion.LookRotation(diff);
		if(transform.position.y < -20.0f){
			Application.LoadLevel("game");
		}
	}

}
