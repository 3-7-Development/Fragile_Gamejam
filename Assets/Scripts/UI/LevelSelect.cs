using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


public class LevelSelect : MonoBehaviour
{
    private UIDocument document;
    [SerializeField] private VisualTreeAsset levelButtonTemplate;
    [SerializeField] private List<LevelObject> levels;
    private void OnEnable()
    {
        document= GetComponent<UIDocument>();

        foreach(LevelObject level in levels)
        {
            LevelButton newButton = new LevelButton(level, levelButtonTemplate);
            document.rootVisualElement.Q("LevelColumn").Add(newButton.button);
        }
        
        
    }
}
