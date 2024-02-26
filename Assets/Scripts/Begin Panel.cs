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



    //ѡ��
    public Rect btn1Pos;//���뷿��
    public Rect btn2Pos;//��������

    private void Awake()
    {
        instance = this;
    }
    private void OnGUI()
    {
       
        
        if(GUI.Button(btn1Pos, "���뷿��"))
        {
            LoggingPanel.ShowMe();
            HideMe();
        }
        if(GUI.Button(btn2Pos, "��������"))
        {
            SettingPanel.ShowMe();
            HideMe();
        }
    }
}
