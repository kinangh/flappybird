using UnityEngine;
using System.Collections;

public class obstaclemovment : MonoBehaviour {
	public float speed = 0;
	public float switchtime = 2;

	void Start () {
		GetComponent<Rigidbody2D> ().velocity = Vector2.up * speed;
		InvokeRepeating ("Switch", 0, switchtime);
	}

	void Switch(){
		GetComponent<Rigidbody2D> ().velocity *= -1;
	}
	void OnCollisionEnter2D(Collision2D call){
		if (gameObject.CompareTag ("Player")) {
			Application.LoadLevel (Application.loadedLevel);
			GetComponent<movment>().score = 0;
			GetComponent<AudioSource>().Play();
		}
	}
}
