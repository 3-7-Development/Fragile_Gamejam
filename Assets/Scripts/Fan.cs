using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fan : MonoBehaviour
{
    public float power = 100f;
    private Vector2 force;
    private void Start()
    {
        float angle = transform.rotation.eulerAngles.z * Mathf.Deg2Rad;
        Vector2 direction = new Vector2( -Mathf.Sin(angle), Mathf.Cos(angle));
        force = direction * power;
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        collision.GetComponent<Rigidbody2D>().AddForce(force,ForceMode2D.Force);
    }
}
