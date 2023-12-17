using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Function : MonoBehaviour
{
    float playerScore;
    public Text scoreText;
    public GameObject gameOverScene;
    public GameObject startGame;
    public GameObject dropFruits;

    public void addScore(int scoreToAdd){
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
    }
    public void gameOver(){
        gameOverScene.SetActive(true);
        dropFruits.SetActive(false);
    }
    public void restartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void playGame(){
        startGame.SetActive(false);
        dropFruits.SetActive(true);
    }
}
