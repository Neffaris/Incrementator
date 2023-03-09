using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Add_value : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _textFieldWithNumber;
    int _startValue = 0;

    public void IncreaseValue()
    {
        _startValue++;
        ShowValue();
    }
    void ShowValue()
    {
        _textFieldWithNumber.text = _startValue.ToString();
    }
}
