using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

	public GameObject Explosion;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Explode(){
		GameObject TempExplosion = Instantiate (Explosion, gameObject.transform.position,Quaternion.identity);
		Destroy (gameObject);
	}
}
