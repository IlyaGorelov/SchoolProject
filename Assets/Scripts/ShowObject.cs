using UnityEngine;

public class ShowObject : MonoBehaviour
{
    public GameObject showObject;
    public float showAtDistance = 0f;
    public Transform fromTheObject;

    private void OnMouseOver()
    {
        if (fromTheObject)
        {
            Vector3 offset = fromTheObject.position - transform.position;
            float sqrLen=offset.sqrMagnitude;
            if(sqrLen<showAtDistance*showAtDistance)
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
        //if(fromTheObject)
        //{
        //    Vector3 offset = fromTheObject.position - transform.position;
        //    float sqrLen = offset.sqrMagnitude;
        //    if (sqrLen > showAtDistance * showAtDistance)
        //    {
        //        showObject.SetActive(false);
                
        //    }
        //}
        Cursor.visible = false;
    }
}
