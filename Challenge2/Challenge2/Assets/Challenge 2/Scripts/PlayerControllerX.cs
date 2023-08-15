using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private float gunHeat;
    private const float TimeDelay = 3.0f;

    // Update is called once per frame
    void Update()
    {
        if(gunHeat > 0)
        {
            gunHeat -= Time.deltaTime;
            Debug.Log("Delay Spawn!");
        }
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(gunHeat <= 0)
            {
                gunHeat = TimeDelay;
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            }
        }
    }

    void MyFunction()
    {
        Debug.Log("Delay Spawn!");
    }
}
