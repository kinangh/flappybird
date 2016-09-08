using UnityEngine;
using System.Collections;

public class obsticalmovment : MonoBehaviour {

    public float speed;
    public float switchtime;

    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;

        InvokeRepeating("Switch", 0, switchtime);
    }
    void Switch()
    {
        GetComponent<Rigidbody2D>().velocity *= -1;
    }
}
