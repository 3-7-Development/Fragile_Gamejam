using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public GameObject bullet;
    public Transform spawn;
    public float power;
    private Vector2 force;
    private void Start()
    {
        float angle = transform.rotation.eulerAngles.z * Mathf.Deg2Rad;
        Vector2 direction = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));
        force = direction * power;

        InvokeRepeating("ShotSpawn", 0f, 3f);

      
    }
 
    private void ShotSpawn()
    {
        GameObject tmp = Instantiate(bullet);
        tmp.transform.position = spawn.position;
        tmp.GetComponent<Rigidbody2D>().AddForce(force, ForceMode2D.Force);

    }
}
