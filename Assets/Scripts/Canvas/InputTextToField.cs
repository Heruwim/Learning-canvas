using UnityEngine;
using TMPro;

public class InputTextToField : MonoBehaviour
{
    public TMP_Text Text;

    public void ToText(string str)
    {
        Text.text = str;
    }
}
