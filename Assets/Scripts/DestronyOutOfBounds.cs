using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestronyOutOfBounds : MonoBehaviour
{
    private GameManager gameManager;
    private float topBound = 30;
    private float lowerBound = -10;
    private float sideBound = 30;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x > sideBound || transform.position.x < -sideBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
            gameManager.DamageCounter();
        }
    }
}
