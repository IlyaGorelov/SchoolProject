using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    Rigidbody rb;
    const string hor = "Horizontal";
    const string ver = "Vertical";
    [SerializeField] float speed;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        float horizontal=Input.GetAxis(hor);
        float vertical=Input.GetAxis(ver);

        Vector3 moveVector = new Vector3(horizontal, 0, vertical);
        rb.velocity = moveVector*speed*Time.deltaTime;
    }
}
