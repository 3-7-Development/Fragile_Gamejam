using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    private static LevelManager _instance;
    public Transform spawnPoint;
    public bool spawning = false;
    [SerializeField] private GameObject playerPrefab;
    [SerializeField]private List<GameObject> players;

    public static LevelManager Instance
    {
        get
        {
            if (_instance == null)
                Debug.LogError("Level Manager is not defined!");

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
    private void Start()
    {
        InvokeRepeating("SpawnPlayer", 0, 3);
    }
    private void SpawnPlayer()
    {
        if(spawning)
        {
            var newPlayer = Instantiate(playerPrefab, spawnPoint.transform.position, Quaternion.identity);
            players.Add(newPlayer); 
        }   
    }
    public void ClearPlayers()
    {
        foreach(GameObject player in players)
        {
            Destroy(player);
        }
    }
}
