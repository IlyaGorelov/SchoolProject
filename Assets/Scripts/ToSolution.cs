using UnityEngine;

public class ToSolution : MonoBehaviour
{
    [SerializeField] private GameObject playerPosition;
    public Transform playerNextPos;
    public static bool isSoluting = false;
    [SerializeField] private GameObject solutionObject;
    [SerializeField] private GameObject TextInputLMB;
    [SerializeField] private FirstPersonController controller;
    private Rigidbody rb;
    [SerializeField] FixedJoystick joystick;

    private void Start()
    {
        rb = playerPosition.GetComponent<Rigidbody>();
    }

    public void ToSolut()
    {
        joystick.gameObject.SetActive(false);
        isSoluting = true;
        solutionObject.SetActive(false);
        TextInputLMB.SetActive(false);
        playerPosition.transform.position = playerNextPos.position;
        controller.playerCanMove = false;
        rb.velocity = Vector3.zero;
        rb.useGravity = false;
        Debug.Log("soluting..");
        controller.enableHeadBob = false;
    }

    private void Update()
    {
        if (isSoluting)
        {
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;

        }
        if (Input.GetKeyDown(KeyCode.Escape) && isSoluting)
        {
            joystick.gameObject.SetActive(true);
            isSoluting = false;
            solutionObject.SetActive(true);
            controller.playerCanMove = true;
            rb.useGravity = true;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            controller.enableHeadBob = true;
        }
    }
}
