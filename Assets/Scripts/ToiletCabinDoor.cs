using UnityEngine;

public class ToiletCabinDoor : MonoBehaviour
{
    [SerializeField] Type thisType;
    enum Type
    {
        door,
        cover
    }


    private void OnMouseOver()
    {
        if (thisType == Type.door)
        {
            if (Input.GetMouseButtonDown(0))
            {
                gameObject.GetComponent<Animator>().enabled = true;
            }
        }
        else if (thisType == Type.cover)
        {

            if (Input.GetMouseButtonDown(0))
            {
                gameObject.SetActive(false);
            }

        }
    }
}
