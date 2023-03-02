using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


public class LevelSelectView : View
{
    [SerializeField] private VisualTreeAsset levelButtonTemplate;
    [SerializeField] private List<LevelObject> levels;
    private Button backButton;

    protected override void OnEnable()
    {
        base.OnEnable();
        backButton = document.rootVisualElement.Q<Button>("BackButton");
        backButton.clicked += () =>
        {
            ViewManager.Show<MainMenuView>();
        };
        foreach (LevelObject level in levels)
        {
            LevelButton newButton = new LevelButton(level, levelButtonTemplate);
            document.rootVisualElement.Q("LevelColumn").Add(newButton.button);
        }
    }
}

