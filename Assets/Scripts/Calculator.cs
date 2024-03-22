using UnityEngine;

public class Calculator : MonoBehaviour
{
    public bool anim = false;

    public void ShowCalc()
    {
        if (anim == false)
        {
            GetComponent<Animator>().SetBool("Ap", !anim);
            GetComponent<Animator>().SetBool("Ex", anim);
            anim = true;
        }
        else if (anim == true)
        {
            Debug.Log("rus");
            GetComponent<Animator>().SetBool("Ap", !anim);
            GetComponent<Animator>().SetBool("Ex", anim);
            anim = false;
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F5))
        {
            if (anim == false)
            {
                GetComponent<Animator>().SetBool("Ap", !anim);
                GetComponent<Animator>().SetBool("Ex", anim);
                anim = true;
            }
            else if (anim == true)
            {
                Debug.Log("Calculator");
                GetComponent<Animator>().SetBool("Ap", !anim);
                GetComponent<Animator>().SetBool("Ex", anim);
                anim = false;
            }
        }
    }
}
