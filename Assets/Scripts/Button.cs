using UnityEngine;
using TMPro;

public class Button : MonoBehaviour
{
    public GameObject text;

    public void OnButtonClick()
    {
        Destroy(text);
    }
}
