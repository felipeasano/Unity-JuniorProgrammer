using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 40.0f;
    private float lowerBound = -25.0f;

    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        // destroi objetos que ultrapassem o limite do jogo
        if(transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        if(transform.position.z < lowerBound)
        {
            //Debug.Log("Game Over from back side!");
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }
        if(transform.position.x > 25 || transform.position.x < -25)
        {
            //Debug.Log("Game Over from L or R side!");
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }
    }
}
