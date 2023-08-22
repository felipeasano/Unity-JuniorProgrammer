using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{

    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // metodo reservado do unity
    // reage a colisoes
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //Debug.Log("Game Over!");
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }
        else if(other.CompareTag("Animal"))
        {
            //gameManager.AddScore(5);
            //Destroy(other.gameObject);
            other.GetComponent<AnimalHanger>().FeedAnimal(1);
            Destroy(gameObject);

        }
    }
}
