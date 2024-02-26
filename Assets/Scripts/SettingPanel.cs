using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingPanel : MonoBehaviour
{
    private static SettingPanel instance;
    public static void ShowMe()
    {
        if (instance != null)
        {
            instance.gameObject.SetActive(true);
        }

    }
    public static void HideMe()
    {
        if (instance != null)
        {
            instance.gameObject.SetActive(false);
        }
    }

    private void Awake()
    {
        instance = this;
        HideMe();
    }
    private void OnGUI()
    {
        if (GUI.Button(new Rect(740,145,40,20), "¹Ø±Õ"))
        {
            HideMe();
            BeginPanel.ShowMe();
        }
    }
}
