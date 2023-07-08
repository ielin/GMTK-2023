using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomBar : MonoBehaviour
{
    public GameObject ball;
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Ball")
        {
            ball.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePosition;
        }
    }
}
