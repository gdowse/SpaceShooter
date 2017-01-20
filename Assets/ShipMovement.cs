using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour {

	public float ShipSpeed;
	public float BulletSpeed;

	public Rigidbody2D projectile;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftArrow)) {
			if (transform.position.x > -6.5) {
				transform.Translate (new Vector3 (-1, 0, 0) * Time.deltaTime * ShipSpeed);
			}
		}
		if (Input.GetKey (KeyCode.UpArrow)) {
			if (transform.position.y < 5) {
				transform.Translate (new Vector3 (0, 1, 0) * Time.deltaTime * ShipSpeed);
			}
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			if (transform.position.x < 6.5) {
				transform.Translate (new Vector3(1,0,0) * Time.deltaTime * ShipSpeed);
			}
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			if (transform.position.y > -5) {
				transform.Translate (new Vector3(0,-1,0) * Time.deltaTime * ShipSpeed);
			}
		}


		if (Input.GetKeyDown(KeyCode.Space)){
			Rigidbody2D instantiatedProjectile = Instantiate(projectile,transform.position - new Vector3(0,-0.5F,0),transform.rotation) as Rigidbody2D;

			instantiatedProjectile.velocity = new Vector3(0, 10, 0);

		}
	}
}
