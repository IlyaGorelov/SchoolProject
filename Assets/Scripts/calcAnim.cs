
using UnityEngine;

public class calcAnim : MonoBehaviour
{
    public Transform calc;
 public  bool anim=false;
    
    
    // Update is called once per frame

    public void AS()
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
                Debug.Log("rus");
                GetComponent<Animator>().SetBool("Ap", !anim);
                GetComponent<Animator>().SetBool("Ex", anim);
                anim = false;
            }
        }
    }


}
