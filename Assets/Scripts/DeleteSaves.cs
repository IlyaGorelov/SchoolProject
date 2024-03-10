using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteSaves : MonoBehaviour
{
    public void DeleteKeys() => PlayerPrefs.DeleteAll();
}
