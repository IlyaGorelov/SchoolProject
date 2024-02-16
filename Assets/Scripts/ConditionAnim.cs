using UnityEngine;

public class ConditionAnim : MonoBehaviour
{
    private Animator animator;

    private bool isExist = false;
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
}
