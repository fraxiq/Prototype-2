using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private float lives = 3;
    private float score;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void DamageCounter()
    {
        lives--;
        if (lives < 1)
        {
            Debug.Log("Game Over!");
        }
        else
        {
            Debug.Log("Got Hit! Lives: " + lives);
        }
    }
    public void ScoreCounter()
    {
        score++;
        Debug.Log("Score: " + score);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
