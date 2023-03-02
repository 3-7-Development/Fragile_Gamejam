using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Break : MonoBehaviour
{
    public GameObject ps;

    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject tmp = Instantiate(ps);
        Vector3 pos = transform.position;
        pos.y += 1f;
        tmp.transform.position= pos;
        Destroy(transform.gameObject);
    }
    
}
