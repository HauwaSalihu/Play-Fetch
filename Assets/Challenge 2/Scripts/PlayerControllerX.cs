using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

        //Declare variables spawning dogs at an interval
    
    private float spawnDog = 1;

    private float start = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog and check too see that the start time
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > start)
        {
            //Reset the start dog spawn time

            start = Time.time + spawnDog;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }

}
