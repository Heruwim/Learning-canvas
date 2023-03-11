using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Toggle : MonoBehaviour
{
    public GameObject Text;

    public void OnToggleChanged(bool state)
    {
        Text.SetActive(state);
    }
}
