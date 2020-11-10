using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerUI : MonoBehaviour
{
    public List<IdComponent> windows = new List<IdComponent>();
    public IdComponent currentWindow;

    public GameObject ShowWindow(string windowId)
    {
        if(currentWindow!= null)
        {
            if (currentWindow.Id == windowId)
                return currentWindow.gameObject;
            currentWindow.gameObject.SetActive(false);
        }

        currentWindow = GetWindow(windowId);
        var window = currentWindow.gameObject;
        window.SetActive(true);
        return window;
    }

    public T GetWindowComponent<T>(string windowId) where T : MonoBehaviour
    {
        return GetWindow(windowId)?.GetComponent<T>();
    }

    public IdComponent GetWindow(string windowId)
    {
        return windows.Find(w => w.Id == windowId);
    }
}
