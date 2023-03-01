using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;


public class LevelButton
{
    internal Button button;
    private LevelObject level;


    public LevelButton(LevelObject level, VisualTreeAsset template)
    {
        this.level = level;

        TemplateContainer levelButtonContainer = template.Instantiate();

        button = levelButtonContainer.Q<Button>();

        if(level.unlocked)
        {
            button.RegisterCallback<ClickEvent>(OnClick);
        }

        button.text = level.displayName;
    }

    private void OnClick(ClickEvent e)
    {
        Debug.Log("Loading " + level.sceneName);
        SceneManager.LoadScene(level.sceneName);
    }
}
