using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewManager : MonoBehaviour
{
    private static ViewManager instance;

    [SerializeField] private View startingView;
    [SerializeField] private View[] views;
    [SerializeField] private View currentView;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public static T GetView<T>() where T : View
    {
        for (int i = 0; i < instance.views.Length; i++)
        {
            if (instance.views[i] is T tView)
            {
                return tView;
            }
        }
        return null;
    }

    public static void Show<T>()
    {
        for (int i = 0; i < instance.views.Length; i++)
        {
            if (instance.views[i] is T)
            {
                if (instance.currentView != null)
                {
                    instance.currentView.Hide();
                }
                instance.views[i].Show();

                instance.currentView = instance.views[i];
            }
        }
    }

    public static void Show(View view)
    {
        if (instance.currentView != null)
        {
            instance.currentView.Hide();
        }
        view.Show();

        instance.currentView = view;
    }

    private void Start()
    {
        for (int i = 0; i < views.Length; i++)
        {
            views[i].enabled = true;
            views[i].Hide();
        }
        if (startingView != null)
        {
            Show(startingView);
        }
    }
}