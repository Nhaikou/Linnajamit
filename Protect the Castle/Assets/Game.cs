using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour
    {
        private GUIText scoreText;
        public string stringi;
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
        }

        public void AddScore(int newScoreValue)
        {
            score += newScoreValue;
        }
        // Update is called once per frame
        public void Update()
        {
            timer = Time.time;

            scoreText = GameObject.Find("GUI/txt-Score").GetComponent<GUIText>();
            if (timer >= 10)
            {
                multiplier += 1;
                timer = 0;
            }

            newScoreValue = 10 * multiplier;
            
            AddScore(newScoreValue);
            UpdateScoreText();
        }
        void UpdateScoreText()
        {
            // update textfield with score
            scoreText.text = score.ToString();
        }
    void OnGUI()
        {
            GUI.Label(new Rect(100, 20, 150, 150), score.ToString());
        }
    public void IsHit()
        {
            multiplier = 1;
            timer = 0;
        }
}

