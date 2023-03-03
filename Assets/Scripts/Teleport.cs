using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform linkedPortal;
<<<<<<< HEAD
    public LayerMask layer;
=======
>>>>>>> 4493fd5 (rick and morthy update)

    public bool tpReady = true;


    private void OnTriggerEnter2D(Collider2D collision)
    {
<<<<<<< HEAD
        if (tpReady && collision.gameObject.layer == 6)
=======
        if (tpReady && collision.tag == "Player")
>>>>>>> 4493fd5 (rick and morthy update)
        {
            linkedPortal.GetComponent<Teleport>().tpReady = false;
            collision.transform.position = linkedPortal.transform.position;
        }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
<<<<<<< HEAD
        if(!tpReady && collision.gameObject.layer == 6)
=======
        if(!tpReady && collision.tag == "Player")
>>>>>>> 4493fd5 (rick and morthy update)
        {
            tpReady= true;
        }
    }

}
