using UnityEngine;

public class ActivateSecEscape : MonoBehaviour
{
    [SerializeField] GameObject gameObject;
    public void Activate()
    {
        if (!Escape.needToGround) gameObject.SetActive(true);
    }
}
