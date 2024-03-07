using UnityEngine;

public class ConditionAnim : MonoBehaviour
{
    private Animator animator;

    private bool isExist = false;

    [SerializeField] FixedJoystick joystick;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F8) && !isExist)
        {
            animator.SetTrigger("ToAppear");
            isExist = true;
        }
        else if (Input.GetKeyDown(KeyCode.F8) && isExist)
        {
            animator.SetTrigger("ToExit");
            isExist = false;
        }
    }

    public void Show()
    {
        if (!isExist)
        {
            animator.SetTrigger("ToAppear");
            isExist = true;
        }
        else if (isExist)
        {
            animator.SetTrigger("ToExit");
            isExist = false;
        }
    }
}
