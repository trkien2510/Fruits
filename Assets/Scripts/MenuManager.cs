using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void playGame(){
        SceneManager.LoadScene("Play");
    }
    public void exitGame(){
        Application.Quit();
    }
    public void exitToMenu(){
        SceneManager.LoadScene("Menu");
    }
}
