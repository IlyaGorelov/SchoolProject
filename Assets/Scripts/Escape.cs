using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Escape : MonoBehaviour
{
    [SerializeField] private GameObject exitMenu;
    public bool isPause = false;
    [SerializeField] private Slider sensetivity;
    [SerializeField] private Slider fov;
    [SerializeField] private Slider velocity;
    public GameObject loadingImage;
    [SerializeField] private FirstPersonController firstPersonController;
    private void Start()
    {
        if (PlayerPrefs.HasKey("Sensetivity"))
        {
            sensetivity.value = PlayerPrefs.GetFloat("Sensetivity");
            firstPersonController.mouseSensitivity = PlayerPrefs.GetFloat("Sensetivity");
        }
        else
        {
            sensetivity.value = firstPersonController.mouseSensitivity;
        }
        if (PlayerPrefs.HasKey("Fov"))
        {
            fov.value = PlayerPrefs.GetFloat("Fov");
            firstPersonController.fov = PlayerPrefs.GetFloat("Fov");
        }
        else
        {
            fov.value = firstPersonController.fov;
        }
        if (PlayerPrefs.HasKey("Velocity"))
        {
            velocity.value = PlayerPrefs.GetFloat("Velocity");
            firstPersonController.walkSpeed = PlayerPrefs.GetFloat("Velocity");
        }
        else
        {
            velocity.value = firstPersonController.walkSpeed;
        }
        exitMenu.SetActive(false);
        Time.timeScale = 1;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !isPause && firstPersonController.isGrounded)
        {
            Debug.Log(ToSolution.isSoluting);
            exitMenu.SetActive(true);
            isPause = true;
            firstPersonController.cameraCanMove = false;
            if (isPause)
            {
                Cursor.lockState = CursorLockMode.Confined;
                Cursor.visible = true;
            }
            Time.timeScale = 0.0f;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && isPause)
        {
            exitMenu.SetActive(false);
            isPause = false;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            Time.timeScale = 1.0f;
            firstPersonController.cameraCanMove = true;
        }
    }

    public void Exit()
    {
        StartCoroutine(LOadingScreenOnFable());
    }

    public void ChangeSense()
    {
        firstPersonController.mouseSensitivity = sensetivity.value;
        PlayerPrefs.SetFloat("Sensetivity", firstPersonController.mouseSensitivity);
        Debug.Log(sensetivity.value);
    }

    public void ChangeFov()
    {
        firstPersonController.fov = fov.value;
        PlayerPrefs.SetFloat("Fov", firstPersonController.fov);
    }

    public void ChangeVelocity()
    {
        firstPersonController.walkSpeed = velocity.value;
        PlayerPrefs.SetFloat("Velocity", firstPersonController.walkSpeed);
    }

    IEnumerator LOadingScreenOnFable()
    {
        loadingImage.SetActive(true);
        AsyncOperation operation = SceneManager.LoadSceneAsync(0);
        Debug.Log("RUS");
        yield return operation;
    }
}
