using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeginPanel : MonoBehaviour
{
    private static BeginPanel instance;
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



    //选项
    public Rect btn1Pos;//进入房间
    public Rect btn2Pos;//创建房间

    private void Awake()
    {
        instance = this;
    }
    private void OnGUI()
    {
       
        
        if(GUI.Button(btn1Pos, "进入房间"))
        {
            LoggingPanel.ShowMe();
            HideMe();
        }
        if(GUI.Button(btn2Pos, "创建房间"))
        {
            SettingPanel.ShowMe();
            HideMe();
        }
    }
}
