using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Commands : MonoBehaviour
{
    public command[] commandList;
    public void checkCommand(string input)
    {
        input = input.ToLower();
        foreach (command com in commandList)
        {
            if (input.StartsWith(com.startsWith))
            {
                Debug.Log("Detected " + com.startsWith);
                com.trigger.Invoke(input);
                return;
            }
        }
        
    }

    [System.Serializable]  

    public class command
    {
        public string startsWith;
        public UnityEvent<string> trigger;
        

        
    }


}
