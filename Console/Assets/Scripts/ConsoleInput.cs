using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ConsoleInput : MonoBehaviour
{
    public TMP_InputField consoleField;
    public TextMeshProUGUI outputText;
    private Commands commands;
    void Start()
    {
        consoleField.Select();
        commands = GetComponent<Commands>();
    }

    void Update()
    {
        if (consoleField.isFocused == false)
        {
            consoleField.Select();
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            outputText.text += "\n>" + consoleField.text;
            commands.checkCommand(consoleField.text);
            consoleField.text = "";
            consoleField.ActivateInputField();
            consoleField.Select();
        }

    }

    public void Output(string outputString)
    {
        Debug.Log("Outputting, outputString = " + outputString);
        outputText.text += "\n" + outputString;

    }

}
