using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour
    {
        public GUIText scoreText;
        private int score;
        public float timer;
        public int multiplier;
        public int newScoreValue;
        public bool isHit;
        public bool gameOver;
        public bool restart;
        public bool exit;
        void Start()
        {
            score = 0;
            timer = 0;
            multiplier = 1;
            isHit = false;
            gameOver = false;
            restart = false;
            exit = false;
            GameController();
        }
        public void GameController()
        {
            while (!exit)
            {

            }

            UpdateScore();
        }
        public void AddScore(int newScoreValue)
        {
            score += newScoreValue;
            UpdateScore();
        }
        // Update is called once per frame
        void UpdateScore()
        {
            scoreText.text = "Score: " + score;
            timer += 1;
            if (timer >= 10)
                multiplier += 1;
            // vaiko NumBlocks ???

            newScoreValue = 10 * multiplier;

            if (isHit == true)
                multiplier = 1;

            AddScore(newScoreValue);
        }
}

