using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject instructionPanel; // Optional if you want to show/hide
    public Button exitButton;

    private void Start()
    {
        exitButton.onClick.AddListener(ExitGame);
    }

    public void ExitGame()
    {
        Debug.Log("Exiting game...");
        Application.Quit();

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // For stopping in editor
#endif
    }
}
