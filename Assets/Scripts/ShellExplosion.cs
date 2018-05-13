using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellExplosion : MonoBehaviour {
	public float m_MaxLifeTime = 2f;
	private void Start (){
        //これまでに破棄されていない場合は、生存期間が過ぎたら砲弾を破棄。
        Destroy (gameObject, m_MaxLifeTime);
    }
    private void OnTriggerEnter (Collider other){

        // 砲弾を破棄
        Destroy (gameObject);
    }
}
