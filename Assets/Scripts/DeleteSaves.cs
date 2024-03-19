
using UnityEngine;

public class DeleteSaves : MonoBehaviour
{
    public void Delete() => PlayerPrefs.DeleteAll();
    
}
