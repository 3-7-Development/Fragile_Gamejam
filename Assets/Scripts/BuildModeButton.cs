using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildModeButton : MonoBehaviour
{
    [SerializeField]private Button button;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.buildModeOn)
            button.interactable = false;
        else button.interactable = true;
    }
}
