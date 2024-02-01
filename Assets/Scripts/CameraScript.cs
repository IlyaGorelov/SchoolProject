using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public float mouseSensevity;
    float lastMouseSensetivity;
    public Transform character;
    public float xRotation;
    bool isFixed = false;
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        if (PlayerPrefs.HasKey("sensetivity"))
            mouseSensevity = PlayerPrefs.GetFloat("sensetivity");
    }

    private void Update()
    {
        if (Time.timeScale == 1f)
        {
            float mouseX = Input.GetAxis("Mouse X") * mouseSensevity;
            float mouseY = Input.GetAxis("Mouse Y") * mouseSensevity;
            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -90f, 90f);

            transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
            character.Rotate(Vector3.up * mouseX);
        }

        if (!isFixed && Input.GetKeyDown(KeyCode.F1))
        {
            lastMouseSensetivity = mouseSensevity;
            mouseSensevity = 0;
            isFixed = true;
        }
        else if (isFixed && Input.GetKeyDown(KeyCode.F1))
        {
            mouseSensevity = lastMouseSensetivity;
            isFixed = false;
        }
    }
}
