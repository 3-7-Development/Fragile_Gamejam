using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform linkedPortal;
    public LayerMask layer;

    public bool tpReady = true;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (tpReady && collision.gameObject.layer == 6)
        {
            linkedPortal.GetComponent<Teleport>().tpReady = false;
            collision.transform.position = linkedPortal.transform.position;
        }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if(!tpReady && collision.gameObject.layer == 6)
        {
            tpReady= true;
        }
    }

}
