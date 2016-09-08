using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Restart : MonoBehaviour {
	public Text leveltext;
	public int unlock1;
	public GameObject star1;
	public GameObject star2;
	public GameObject star3;

	public void OnClick(){
		Application.Quit ();
	}
	public void onstartgame(){
		Application.LoadLevel ("levelsmenu");
	}
	public void onmenuclick(){
		Application.LoadLevel ("menu");
	}
	public void onclicklevel1(){
		Application.LoadLevel ("level1");
	}
	public void onclicklevel2(){
		Application.LoadLevel ("level2");
	}
	public void onclicklevel3(){
		Application.LoadLevel ("level3");
	}
	public void onclicklevel4(){
		Application.LoadLevel ("level4");
	}
	public void onclicklevel5(){
		Application.LoadLevel ("level5");
	}
}