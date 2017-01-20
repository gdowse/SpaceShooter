using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine(MyCoroutine());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator MyCoroutine ()
	{
		yield return new WaitForSeconds(1f);
		Destroy (gameObject);
	}
}
