using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueEventManager : MonoBehaviour
{
    public GameObject cowContainer;
    public GameObject cowFieldContainer;
    public GameObject cropFieldContainer;

    public void Interpret (string eventName)
    {
        if (eventName.Equals("methane_appear"))
        {
            //List<GameObject> cows = cowContainer.
        }
        else if (eventName.Equals("cows_disappear"))
        {
            Disappear(cowContainer);
        }
        else if (eventName.Equals("wheat_fill"))
        {
            Disappear(cowFieldContainer);
            Appear(cropFieldContainer);
        }
        else if (eventName.Equals("factory_appear"))
        {
            
        }
        else
        {
            Debug.Log("There is no functionality for the dialogue event \"" + eventName + ".\"");
        }
    }

    public void Appear(GameObject obj)
    {
        // You can do a fancier fade animation here or play a sound
        this.enabled = true;
    }

    public void Disappear (GameObject obj)
    {
        // You can do a fancier fade animation here or play a sound
        this.enabled = false;
    }
}
