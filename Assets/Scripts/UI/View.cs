using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public abstract class View : MonoBehaviour
{
    protected UIDocument document;
    protected virtual void OnEnable()
    {
        document= GetComponent<UIDocument>();
    }

    public virtual void Hide() => document.rootVisualElement.style.display = DisplayStyle.None;
    public virtual void Show() => document.rootVisualElement.style.display = DisplayStyle.Flex;
}