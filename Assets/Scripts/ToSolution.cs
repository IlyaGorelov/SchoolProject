using UnityEngine;

public class ToSolution : MonoBehaviour
{

    [SerializeField] GameObject playerPosition;
    public Transform playerNextPos;
    public float speed;
    public static bool isSoluting = false;
    [SerializeField] GameObject solutionObject;
    [SerializeField] GameObject TextInputLMB;
    [SerializeField] FirstPersonController controller;
    Rigidbody rb;
    float playerSpeed;
    private void Start()
    {
        rb=playerPosition.GetComponent<Rigidbody>();
    }
    public void ToSolut()
    {
        isSoluting = true;
        solutionObject.SetActive(false);
        TextInputLMB.SetActive(false);
        playerPosition.transform.position = playerNextPos.position;
        playerSpeed = controller.walkSpeed;
        controller.walkSpeed = 0;
        rb.useGravity = false;

    }

    private void Update()
    {
        if (isSoluting)
        {
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            isSoluting = false;
            solutionObject.SetActive(true);
            controller.walkSpeed = playerSpeed;
            rb.useGravity = true;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }
}
