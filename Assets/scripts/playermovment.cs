using UnityEngine;
using System.Collections;

public class playermovment : MonoBehaviour {

    public float speed = 2;
    public float force = 300;

    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
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
        Application.LoadLevel(Application.loadedLevel);
    }
}
