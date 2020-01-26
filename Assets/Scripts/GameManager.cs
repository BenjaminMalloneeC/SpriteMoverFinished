using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject beachball;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            beachball.SetActive(!beachball.activeInHierarchy);
        }

        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            Application.Quit();
        }
    }
}
