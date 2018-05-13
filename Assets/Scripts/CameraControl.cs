using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour{
	public Transform target; 	// ターゲットへの参照
	public Transform verRot;
	public Transform horRot;

	private Vector3 offset;		// 相対座標
	void Start (){
		//自分自身とtargetとの相対距離を求める
		offset = GetComponent<Transform>().position - target.position;
		verRot = transform.parent;
 		horRot = GetComponent<Transform>();
	}
	
	void Update (){
		// 自分自身の座標に、targetの座標に相対座標を足した値を設定する
		GetComponent<Transform>().position = target.position + offset;
		
		float X_Rotation = Input.GetAxis("Mouse X");
 		float Y_Rotation = Input.GetAxis("Mouse Y");

 		verRot.transform.Rotate(0, -X_Rotation, 0);
 		horRot.transform.Rotate(Y_Rotation, 0, 0);
	}
}