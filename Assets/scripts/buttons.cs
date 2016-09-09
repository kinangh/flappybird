using UnityEngine;
using System.Collections;

public class buttons : MonoBehaviour {

    public GameObject menu;
    public GameObject menubutton;

    void Start()
    {
        menu.SetActive(false);
        menubutton.SetActive(true);
    }

    public void OnClickExit()
    {
        Application.Quit();
    }

    public void OnClickRestart()
    {
        Application.LoadLevel(Application.loadedLevel);
        Time.timeScale = 1f;
    }

    public void OnClickMenu()
    {
        Time.timeScale = 0f;
        menu.SetActive(true);
        menubutton.SetActive(false);
    }
}
