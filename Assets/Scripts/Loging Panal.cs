using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Timeline;

public class LoggingPanel : MonoBehaviour
{

    private static LoggingPanel instance;
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
    public Rect btn1Pos;
    public Rect btn2Pos;
    public Rect lab1Pos;
    public Rect lab2Pos;
    public Rect input1Pos;
    public Rect input2Pos;

    public string userName;
    public string passWord;
    private void Awake()
    {
        instance = this;
        HideMe();
    }
    private void OnGUI()
    {
        if(GUI.Button(btn1Pos,"��¼"))
        {
            if(userName=="admin"&&passWord=="8888")
            {
                SceneManager.LoadScene("����ת������");
                //��ʱ������������ҳ�����
            }
            else
            {
                Debug.Log("�û������������");
            }
        }
        if(GUI.Button(btn2Pos,"����"))
        {
            BeginPanel.ShowMe();
            HideMe();
        }
        GUI.Label(lab1Pos,"�û���");
        GUI.Label(lab2Pos,"����");
        userName=GUI.TextField(input1Pos,userName);
        passWord=GUI.TextField(input2Pos,passWord);
    }
}
