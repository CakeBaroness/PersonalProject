using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{

    bool player_detection = false; 

    // Update is called once per frame
    void Update()
    {
        if (player_detection)
        {
            print("Press E to Enter");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Ghost")
        {
            player_detection = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        player_detection = false;
    }
}
