using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


public class MainMenuView : View
{
    private Button playButton;

    protected override void OnEnable()
    {
        base.OnEnable();
        var root = GetComponent<UIDocument>().rootVisualElement;
        playButton = root.Q<Button>("PlayButton");
        playButton.clicked += () =>
        {
            ViewManager.Show<LevelSelectView>();
        };
    }
}
