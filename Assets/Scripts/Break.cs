using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Break : MonoBehaviour
{
<<<<<<< HEAD
    public GameObject ps;

    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject tmp = Instantiate(ps);
        Vector3 pos = transform.position;
        pos.y += 1f;
        tmp.transform.position= pos;
        Destroy(transform.gameObject);
    }
    
=======
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(transform.gameObject);
    }
>>>>>>> 4493fd5 (rick and morthy update)
}
