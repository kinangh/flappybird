using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System.Collections.Generic;
using UnityEngine.UI;

public class levelsmangeremty : MonoBehaviour {

	[System.Serializable]
	public class level
	{
		public string leveltext;
		public int unlocked;
		public bool isinteractble;
	}

	public GameObject levelbutton;
	public Transform spacer;
	public List<level> levellist;

	void Start () {
		FillList ();
	}

	void FillList(){
		foreach (var level in levellist) {
			GameObject newbutton = Instantiate (levelbutton) as GameObject; 
			Restart button = newbutton.GetComponent<Restart>();
			button.leveltext.text = level.leveltext;

			if(PlayerPrefs.GetInt("level" + button.leveltext.text)==1){
				level.unlocked = 1;
				level.isinteractble = true;
			}

			button.unlock1 = level.unlocked;
			button.GetComponent<Button>().interactable=level.isinteractble;
			button.GetComponent<Button>().onClick.AddListener(() => loadLevels("level"+button.leveltext.text));

			if(PlayerPrefs.GetInt("level"+button.leveltext.text+"_score") > 0){
				button.star1.SetActive(true);
			}
			if(PlayerPrefs.GetInt("level"+button.leveltext.text+"_score") >= 1000){
				button.star2.SetActive(true);
			}
			if(PlayerPrefs.GetInt("level"+button.leveltext.text+"_score") >= 100000){
				button.star3.SetActive(true);
			}
			newbutton.transform.SetParent(spacer, false);
		}
		SaveAll ();
	}

	void SaveAll(){
		if (PlayerPrefs.HasKey ("level1")) {
			return;
		} else {
			GameObject[] allButtons = GameObject.FindGameObjectsWithTag("levelbutton");
			foreach (GameObject buttons in allButtons) {
				Restart button = buttons.GetComponent<Restart>();
				PlayerPrefs.SetInt("level"+button.leveltext.text, button.unlock1);
		}
		}
	}
	void loadLevels (string value){
		Application.LoadLevel (value);
	}

	void DeleteAll(){
		PlayerPrefs.DeleteAll ();
	}

	void Update () {
	
	}
}
