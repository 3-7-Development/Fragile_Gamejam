using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObj : MonoBehaviour
{
    public void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0)) // Right mouse button
        {
            Destroy(gameObject);
        }
    }
}
