using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float dogDelay = 1.5f;
    private float lastDogSpawn;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time - lastDogSpawn > dogDelay)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            lastDogSpawn = Time.time;
        }
    }
}
