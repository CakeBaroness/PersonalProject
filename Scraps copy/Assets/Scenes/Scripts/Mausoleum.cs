using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mausoleum: MonoBehaviour
{
    string currentScene = " ";

    // Start is called before the first frame update
    void Start()
    {
        currentScene = SceneManager.GetActiveScene().name;
        Debug.Log(currentScene);
    }

    // Update is called once per frame
    private void OnMouseDown()
    {
            SceneManager.LoadScene("Win");
    }

}