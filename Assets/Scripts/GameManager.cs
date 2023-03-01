using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    [SerializeField] private GameObject playerPrefab;
    public static bool buildModeOn = false;
    private static bool playerSpawnInProgress;
    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
                Debug.LogError("Game Manager is not defined!");

            return _instance;
        }
    }

    public void BuildModeOff()
    {
        if (buildModeOn)
        {
            buildModeOn = false;
            if (!playerSpawnInProgress)
            {
                playerSpawnInProgress = true;
                StartCoroutine(Playerspawn());
            }
        }

        Debug.Log(buildModeOn);
    }
    public void BuildModeOn()
    {
        if (!buildModeOn) { 
            buildModeOn = true;
        }
        Debug.Log(buildModeOn);
    }
    public void StartPlayerSpawn()
    {
        if (!buildModeOn && !playerSpawnInProgress)
        {
            playerSpawnInProgress = true;
            StartCoroutine(Playerspawn());
        }
    }
    public IEnumerator Playerspawn()
    {
        yield return new WaitForSeconds(3);
        playerSpawnInProgress = false;
        Instantiate(playerPrefab, LevelManager.Instance.spawnPoint.transform.position, Quaternion.identity);
    }

    private void Awake()
    {
        if(_instance == null) _instance = this;
        else Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
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
