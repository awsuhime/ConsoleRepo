using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ConsoleInput : MonoBehaviour
{
    public TMP_InputField consoleField;
    void Start()
    {
        consoleField.Select();
    }

    void Update()
    {
        if (consoleField.isFocused == false)
        {
            consoleField.Select();
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            consoleField.text = "";
            consoleField.ActivateInputField();
            consoleField.Select();
        }

    }

    public void Reselect()
    {
        
    }
}
