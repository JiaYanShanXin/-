using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    
    public class SceneSwitcher : EditorWindow
    {
        private string[] sceneNames;
        private int selectedSceneIndex = 0;

        [MenuItem("Window/Scene Switcher")]
        public static void ShowWindow()
        {
            GetWindow<SceneSwitcher>("Scene Switcher");
        }
    }
}
