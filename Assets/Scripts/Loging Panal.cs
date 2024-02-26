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
        if(GUI.Button(btn1Pos,"登录"))
        {
            if(userName=="admin"&&passWord=="8888")
            {
                SceneManager.LoadScene("试验转换场景");
                //到时候连上虚拟教室场景名
            }
            else
            {
                Debug.Log("用户名或密码错误");
            }
        }
        if(GUI.Button(btn2Pos,"返回"))
        {
            BeginPanel.ShowMe();
            HideMe();
        }
        GUI.Label(lab1Pos,"用户名");
        GUI.Label(lab2Pos,"密码");
        userName=GUI.TextField(input1Pos,userName);
        passWord=GUI.TextField(input2Pos,passWord);
    }
}
