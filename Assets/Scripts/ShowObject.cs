using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowObject : MonoBehaviour
{
    public GameObject showObject;
    public float showAtDistance = 0f;
    public Transform fromTheObjcet;

    Controller controller;

    private void OnMouseOver()
    {
        if (fromTheObjcet)
        {
            Vector3 offset = fromTheObjcet.position - transform.position;
            float sqrLen=offset.sqrMagnitude;
            if(sqrLen<showAtDistance  *showAtDistance)
            {
                showObject.SetActive(true);
                Cursor.lockState = CursorLockMode.Confined;
            }
        }
    }

    private void OnMouseExit()
    {
       
            Cursor.lockState = CursorLockMode.Locked;
            showObject.SetActive(false);
        
    }

    private void Update()
    {
        if(fromTheObjcet)
        {
            Vector3 offset = fromTheObjcet.position - transform.position;
            float sqrLen = offset.sqrMagnitude;
            if (sqrLen > showAtDistance * showAtDistance)
            {
                showObject.SetActive(false);
                
            }
        }
    }
}
