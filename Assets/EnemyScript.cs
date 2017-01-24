using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

	public GameObject Explosion;

    public float MoveSpeed = 2.0f;

    public float frequency = 20.0f;  // Speed of sine movement
    public float magnitude = 0.5f;   // Size of sine movement

    private Vector3 axis;
    private Vector3 pos;

    private float startTime;

	// Use this for initialization
	void Start () {
        startTime = Time.time;
        pos = transform.position;
        axis = new Vector3(1,0,0);  // May or may not be the axis you want
	}
	
	// Update is called once per frame
	void Update () {
        
        transform.position = pos + axis * Mathf.Sin ((Time.time - startTime) * frequency) * magnitude;
        pos += transform.up * Time.deltaTime * MoveSpeed;

       
	}

	public void Explode(){
		Instantiate (Explosion, gameObject.transform.position,Quaternion.identity);
		Destroy (gameObject);
	}
}
