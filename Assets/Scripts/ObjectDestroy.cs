using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroy : MonoBehaviour
{

    public GameObject ps;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "killbrick")
        {
            Debug.Log("Hit Registered");
            GameObject tmp = Instantiate(ps);
            Vector3 pos = transform.position;
            pos.y += 1f;
            tmp.transform.position = pos;
            Destroy(gameObject);

            GameManager.Instance.StartPlayerSpawn();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
