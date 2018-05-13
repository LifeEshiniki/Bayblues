using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour {
	// トリガーとの接触時に呼ばれるコールバック
	void OnTriggerEnter(Collider hit){
		GetComponent<ParticleSystem>().Play();
		// このコンポーネントを持つGameObjectを破棄する
		Destroy(gameObject);
	}
}