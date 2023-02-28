using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    private static LevelManager _instance;
    public Transform spawnPoint;
    public static LevelManager Instance
    {
        get
        {
            if (_instance == null)
                Debug.LogError("Game Manager is not defined!");

            return _instance;
        }
    }

    public void Victory()
    {
        Debug.Log("You've Won!");
    }
    private void Awake()
    {
        if (_instance == null) _instance = this;
        else Destroy(gameObject);
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
