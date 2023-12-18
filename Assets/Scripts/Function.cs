using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Function : MonoBehaviour
{
    float playerScore;
    public Text scoreText;
    public GameObject player;
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
        GameObject playerPrefab = Instantiate(player, new Vector2(0f, -3.2f), transform.rotation);
        playerPrefab.SetActive(true);
        scoreText.text = 0.ToString();
        gameOverScene.SetActive(false);
        dropFruits.SetActive(true);
    }
    public void playGame(){
        GameObject playerPrefab = Instantiate(player, new Vector2(0f, -3.2f), transform.rotation);
        playerPrefab.SetActive(true);
        startGame.SetActive(false);
        dropFruits.SetActive(true);
    }
}
