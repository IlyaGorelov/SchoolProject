using UnityEngine;

public class CameraZone : MonoBehaviour
{
    [SerializeField] FirstPersonController controller;

    //private void Start()
    //{
    //    controller = GetComponentInParent<FirstPersonController>();
    //}

    private void OnMouseOver()
    {
        Debug.Log("DDDD");
        //if (controller.cameraCanMove)
        //{
        //    controller.yaw = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * controller.mouseSensitivity;

        //    if (!controller.invertCamera)
        //    {
        //        controller.pitch -= controller.mouseSensitivity * Input.GetAxis("Mouse Y");
        //    }
        //    else
        //    {
        //        // Inverted Y
        //        controller.pitch += controller.mouseSensitivity * Input.GetAxis("Mouse Y");
        //    }

        //    // Clamp pitch between lookAngle
        //    controller.pitch = Mathf.Clamp(controller.pitch, -controller.maxLookAngle, controller.maxLookAngle);

        //    transform.localEulerAngles = new Vector3(0, controller.yaw, 0);
        //    controller.playerCamera.transform.localEulerAngles = new Vector3(controller.pitch, 0, 0);
        //}
    }
}
