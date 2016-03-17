using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour
{
    private GUIText scoreText;
    private int score;
    public float timer;
    public int multiplier;
    public int newScoreValue;
    public bool gameOver;
    public bool restart;
    public bool exit;

    void Start()
    {
        scoreText = null;
        score = 0;
        timer = 0;
        multiplier = 1;
        gameOver = false;
        restart = false;
        exit = false;
        GameController();
    }

    public void GameController()
    {

    }

    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
    }

    // Update is called once per frame
    public void Update()
    {
        //scoreText.text = "Score: " + score.ToString();
        if ((Time.time - timer) >= 1)
        {
            multiplier += 1;
            timer = Time.time;
        }
        // vaiko NumBlocks ???

        newScoreValue = 10 * multiplier;
            
        AddScore(newScoreValue);
    }

    void OnGUI()
    {
        //GUI.Label(new Rect(10, 10, 100, 100), scoreText.text);
    }

    public void IsHit()
    {
        multiplier = 1;
        timer = Time.time;
    }
}

