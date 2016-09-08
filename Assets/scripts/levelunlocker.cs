using UnityEngine;
using System.Collections;

public class playsceen : MonoBehaviour {
	
	void Start () {
		PlayerPrefs.SetInt ("level_score", GetComponent<movment> ().score);
	}

	void Update () {

	}
}
