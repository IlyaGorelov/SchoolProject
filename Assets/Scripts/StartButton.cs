using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour

{
    // Start is called before the first frame update
    public GameObject buttonPrefab;
    void Start()
    {
        Time.timeScale = 0f;
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Time.timeScale = 1f;
            buttonPrefab.SetActive(false);
        }
    }
}
