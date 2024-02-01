using UnityEngine;
public class Controller : MonoBehaviour
{
    public float speed = 10f;
    public CharacterController characterController;
    public GameObject Point;
    public GameObject Empty;
    Vector3 move;
    Vector3 velocity;
    public GameObject ToSolObj;
    public Transform playerSecPos;
    public float speedTel;
    Vector2 player1pos;
    Vector3 playerNewPos;
    public float gravity = -22f;
   // public GameObject show;
    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        move = transform.right * horizontal + transform.forward * vertical;
        characterController.Move(move*speed*Time.deltaTime);
        velocity.y += gravity * Time.deltaTime;
        characterController.Move(velocity * Time.deltaTime);
        if (gravity==0)
        {
            player1pos = transform.position;
            transform.position = playerSecPos.position;
            ToSolObj.SetActive(false);
            if (Input.GetKeyDown(KeyCode.Escape)&& gravity==0)
            {
                ToSolObj.SetActive(true);
                speed = 10;
                gravity = -22f;
                Empty.SetActive(false);
                Point.SetActive(true);
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
             //   show.SetActive(true);
            }
        }
    }
    public void ToSolut()
    {
        ToSolObj.SetActive(false);
        gravity = 0;
        speed = 0;
        Empty.SetActive(true);
        Point.SetActive(false);
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
       // show.SetActive(false);
    }
}
