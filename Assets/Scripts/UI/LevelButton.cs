using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
<<<<<<< HEAD
using UnityEngine.SceneManagement;

=======
>>>>>>> 58197e4 (Napraw sie konflikcie)

public class LevelButton
{
    internal Button button;
    private LevelObject level;

<<<<<<< HEAD

=======
>>>>>>> 58197e4 (Napraw sie konflikcie)
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
<<<<<<< HEAD
        Debug.Log("Loading " + level.sceneName);
        SceneManager.LoadScene(level.sceneName);
=======
        Debug.Log("Loading" + level.sceneName);
>>>>>>> 58197e4 (Napraw sie konflikcie)
    }
}
