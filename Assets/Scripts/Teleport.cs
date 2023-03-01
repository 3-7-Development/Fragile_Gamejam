using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform linkedPortal;

    public bool tpReady = true;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (tpReady && collision.tag == "Player")
        {
            linkedPortal.GetComponent<Teleport>().tpReady = false;
            collision.transform.position = linkedPortal.transform.position;
        }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if(!tpReady && collision.tag == "Player")
        {
            tpReady= true;
        }
    }

}
