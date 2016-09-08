using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class movment : MonoBehaviour {
	public float speed = 2;
	public float force = 300;

	public int score = 0;
	public Text scoretext;
	public int scorevalue;

	void Start () {
		PlayerPrefs.SetInt ("level_score",score);
	}
     
	void Update () {
	if (Input.GetKeyDown (KeyCode.Space)) {
			GetComponent<Rigidbody2D> ().velocity = Vector2.right * speed;
			GetComponent<Rigidbody2D>().AddForce(Vector2.up*force);
			GetComponent<AudioSource>().Play ();
		}
	}

	void OnCollisionEnter2D(Collision2D call){
		if (call.gameObject.CompareTag ("coin")) {
			call.gameObject.SetActive(false);
			score = score + scorevalue;
			scoretext.text=("score:"+score);
		}
	}
}
