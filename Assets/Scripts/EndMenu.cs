using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class EndMenu : MonoBehaviour
{
    public void QuitGame()
    {
        if (Application.isEditor)
        {
            UnityEditor.EditorApplication.isPlaying = false;
        } else 
        {
            Application.Quit();
        }
    }
}
