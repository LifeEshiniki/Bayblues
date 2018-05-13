using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	public float shotSpeed;
	public GameObject shellprefab;
    public AudioSource shotSound;

	public ParticleSystem particle;

	private float time;
	// Use this for initialization
	void Start () {
		time = 0f;
		shotSound = GetComponent <AudioSource>();
	}
	
	// Update is called once per frame
	void Update (){
		if(Input.GetButton("Fire1")){
            // ①Shotという名前の関数（命令ブロック）を実行する。
            Shot();
		}
		
	}
	// プレファブから砲弾(Shell)オブジェクトを作成し、それをshellという名前の箱に入れる。
    public void Shot(){
		particle.Play();
		shotSound.PlayOneShot (shotSound.clip);
		GameObject shell =  (GameObject)Instantiate(shellprefab, transform.position, Quaternion.identity); 
        // Rigidbodyの情報を取得し、それをshellRigidbodyという名前の箱に入れる。
        Rigidbody shellRigidbody = shell.GetComponent<Rigidbody>();
        // shellRigidbodyにz軸方向の力を加える。
        shellRigidbody.AddForce(transform.forward * shotSpeed * 100.0f);
	}
}
