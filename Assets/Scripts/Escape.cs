using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Escape : MonoBehaviour
{
    public Controller controller;
    [SerializeField] GameObject exitMenu;
    bool isActive = false;
    [SerializeField] Slider sensetivity;
    public CameraScript cam;
    private void Start()
    {
        sensetivity.maxValue = cam.mouseSensevity;
        sensetivity.value = cam.mouseSensevity;
        exitMenu.SetActive(false);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && controller.gravity != 0 && !isActive)
        {
            exitMenu.SetActive(true);
            isActive = true;
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;
            Time.timeScale = 0.0f;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && controller.gravity != 0 && isActive)
        {
            PlayerPrefs.SetFloat("sensetivity", cam.mouseSensevity);
            exitMenu.SetActive(false);
            isActive = false;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            Time.timeScale = 1.0f;
        }
    }
    public void Exit()
    {
        SceneManager.LoadScene(0);
    }
    public void ChangeSense()
    {
        cam.mouseSensevity = sensetivity.value;
    }
}
