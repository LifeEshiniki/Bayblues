using UnityEngine;
using System.Collections;
using System;
using System.Diagnostics;

public class GameController : MonoBehaviour{
	
	public UnityEngine.UI.Text scoreLabel;
	public float scoreTime = 0f;
	public GameObject ClearLabel;
	public AudioSource cat;

	private float time;
	private static Stopwatch stopwatch = new Stopwatch();  
	bool is_clear;

	void Start(){
		is_clear = false;
		stopwatch.Start (); 
		ClearLabel.SetActive(false);
		cat = GetComponent <AudioSource>();
		
	}
	public void Update (){	
		time += Time.deltaTime;
		int count = GameObject.FindGameObjectsWithTag ("Target").Length;
		scoreLabel.text = count.ToString ();

		
		if(count <= 0){
			if (is_clear==false) { 
				cat.PlayOneShot (cat.clip);
				is_clear = true;
			}
			stopwatch.Stop ();
			ClearLabel.SetActive(true);
			scoreLabel.text = "TIME: " + stopwatch.Elapsed.TotalSeconds.ToString();
			if(Input.GetKey(KeyCode.Space)){
				Application.LoadLevel ("title");
			}
		}
	}
}