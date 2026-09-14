using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Intro_ui_Handler : MonoBehaviour
{
    public GameObject instructionPanel;

    public void ToggleInstructionPanel(string toggle)
    {
        if(toggle == "false")
        {
            instructionPanel.SetActive(false);
        }
        else if(toggle == "true")
        {
            instructionPanel.SetActive(true);
        }
    } 

    public void ChangeCurrentScene(string sceneName)
    {
        Scene currentScene = SceneManager.GetActiveScene();

        int nextIndex = currentScene.buildIndex + 1;
        
        SceneManager.LoadScene(nextIndex);
    }
    
}
