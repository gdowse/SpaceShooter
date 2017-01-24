using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

	public GameObject Explosion;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(transform.position.y > 6){
            Destroy(gameObject);
        }
	}

	void OnTriggerEnter2D(Collider2D other) {
		other.GetComponent<EnemyScript> ().Explode ();
		Destroy (gameObject);
	}
}
