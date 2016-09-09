using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class playermovment : MonoBehaviour {

    public float speed = 2;
    public float force = 300;

    public GameObject menu;
    public GameObject menubutton;

    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;

        menu.SetActive (false);
        menubutton.SetActive(true);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * force);
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "death")
        {
            Application.LoadLevel(Application.loadedLevel);
            Time.timeScale = 1f;
        }

        if (other.gameObject.tag == "levelend")
        {
            Time.timeScale = 0f;
            menu.SetActive(true);
            menubutton.SetActive(false);
        }
    }
}
