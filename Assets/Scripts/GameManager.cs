using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    [SerializeField] private GameObject playerPrefab; 
    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
                Debug.LogError("Game Manager is not defined!");

            return _instance;
        }
    }

    public void StartPlayerSpawn()
    {
        StartCoroutine(Playerspawn());
    }
    public IEnumerator Playerspawn()
    {
        yield return new WaitForSeconds(3);
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
