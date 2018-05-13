using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTarget : MonoBehaviour {
public GameObject Target;
public ParticleSystem Particles;
void OnCollisionEnter(Collision other){
		Particles.Play ();
		Destroy(gameObject);
	}
}
