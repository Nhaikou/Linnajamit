using UnityEngine;
using System.Collections;

public class Text : MonoBehaviour
    {
        private int score;
        public float timer;
        public int multiplier;
        public int newScoreValue;
        public bool gameOver;
        public bool restart;
        public bool exit;
        void Start()
        {
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
            
            if ((Time.fixedTime - timer) >= 10)
            {
                multiplier += 1;
                timer = Time.fixedTime;
            }

            newScoreValue = 10 * multiplier;
            
            AddScore(newScoreValue);
        }

    void OnGUI()
        {
            GUIStyle myStyle = new GUIStyle();
            myStyle.fontSize = 26;
            myStyle.normal.textColor = Color.white;

            GUI.Label(new Rect(140, 60, 150, 150), multiplier.ToString(), myStyle);
            GUI.Label(new Rect(100, 20, 150, 150), score.ToString(), myStyle);
        }
    public void IsHit()
        {
            multiplier = 1;
            timer = Time.fixedTime;
        }
}

