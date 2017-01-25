using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour {

	public float ShipSpeed;
	public float BulletSpeed;

	public int WeaponsLevel;

	public float timeBetweenShots;
	private float timestamp;

	public Rigidbody2D projectile;
	// Use this for initialization
	void Start () {
		WeaponsLevel = 2;
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


		if (Time.time >= timestamp && Input.GetKey(KeyCode.Space)){
			if(WeaponsLevel == 1){
				Vector3 BulletLocation = new Vector3 (0,-0.5F,0);
				Rigidbody2D instantiatedProjectile = Instantiate(projectile,transform.position - BulletLocation,transform.rotation) as Rigidbody2D;

				instantiatedProjectile.velocity = new Vector3(0, 10, 0);
				timestamp = Time.time + timeBetweenShots;
			}

			if(WeaponsLevel == 2){
				Vector3 BulletLocation = new Vector3 (0.5F,-0.3F,0);
				Vector3 BulletLocation2 = new Vector3 (-0.5F,-0.3F,0);
				Rigidbody2D instantiatedProjectile = Instantiate(projectile,transform.position - BulletLocation,transform.rotation) as Rigidbody2D;
				Rigidbody2D instantiatedProjectile2 = Instantiate(projectile,transform.position - BulletLocation2,transform.rotation) as Rigidbody2D;
				instantiatedProjectile.velocity = new Vector3(0, 10, 0);
				instantiatedProjectile2.velocity = new Vector3(0, 10, 0);
				timestamp = Time.time + timeBetweenShots;
			}

		}
	}
}
