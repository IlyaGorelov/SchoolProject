using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Escape : MonoBehaviour
{
    [SerializeField] Rigidbody controller;
    [SerializeField] GameObject exitMenu;
    bool isActive = false;
    [SerializeField] Slider sensetivity;
    public GameObject loadingImage;
    private void Start()
    {
        exitMenu.SetActive(false);
        Time.timeScale = 1;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)  && !isActive)
        {
            exitMenu.SetActive(true);
            isActive = true;
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;
            Time.timeScale = 0.0f;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && isActive)
        {
           // PlayerPrefs.SetFloat("sensetivity", cam.mouseSensevity);
            exitMenu.SetActive(false);
            isActive = false;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            Time.timeScale = 1.0f;
        }
    }
    public void Exit()
    {
        StartCoroutine(LOadingScreenOnFable());
    }
    public void ChangeSense()
    {
       // cam.mouseSensevity = sensetivity.value;
    }

    IEnumerator LOadingScreenOnFable()
    {
        loadingImage.SetActive(true);
        AsyncOperation operation = SceneManager.LoadSceneAsync(0);
        Debug.Log("RUS");
        yield return operation;
    }
}
