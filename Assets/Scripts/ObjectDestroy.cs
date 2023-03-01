using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroy : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "killbrick")
        {
            Debug.Log("Hit Registered");
            Destroy(gameObject);
        }
    }
}
