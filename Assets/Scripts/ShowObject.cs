using UnityEngine;

public class ShowObject : MonoBehaviour
{
    public GameObject showObject;
    public float showAtDistance = 0f;
    public Transform fromTheObject;
    Escape escape;

    private void Start()
    {
        Cursor.visible = false;
        escape = GameObject.FindGameObjectWithTag("Escape").GetComponent<Escape>();
    }
    private void OnMouseOver()
    {
        if (fromTheObject && !escape.isPause)
        {
            Vector3 offset = fromTheObject.position - transform.position;
            float sqrLen = offset.sqrMagnitude;
            if (sqrLen < showAtDistance * showAtDistance)
            {
                showObject.SetActive(true);
                Cursor.lockState = CursorLockMode.Confined;
            }
        }
    }

    private void OnMouseExit()
    {
        if (!escape.isPause)
        {
            Cursor.lockState = CursorLockMode.Locked;
            showObject.SetActive(false);

        }
    }
}
