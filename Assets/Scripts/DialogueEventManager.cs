using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueEventManager : MonoBehaviour
{
    public GameObject cowContainer;
    public GameObject cowFieldContainer;
    public GameObject cropFieldContainer;
    public GameObject factoryObject;
    public GameObject outsideScene;
    public GameObject factoryScene;
    public GameObject transformer;

    public void Interpret (string eventName)
    {
        Debug.Log(eventName);

        if (eventName.Equals("methane_appear"))
        {
            Cow[] cows = cowContainer.GetComponentsInChildren<Cow>();

            foreach (Cow c in cows)
            {
                c.methane.SetActive(true);
            }
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
            Appear(factoryObject);
        }
        else
        {
            Debug.Log("There is no functionality for the dialogue event \"" + eventName + ".\"");
        }
    }

    public void Appear(GameObject obj)
    {
        // You can do a fancier fade animation here or play a sound
        Debug.Log("Made " + obj.name + "appear");
        obj.SetActive(true);
    }

    public void Disappear (GameObject obj)
    {
        // You can do a fancier fade animation here or play a sound
        Debug.Log("Made " + obj.name + "disappear");
        obj.SetActive(false);
    }

    public void swapScenes ()
    {
        Animator a = transformer.GetComponent<Animator>();
        a.Play("Shrink");

        Transformer tfScript = transformer.GetComponent<Transformer>();

        while (tfScript.animating)
        {
            // hold
        }

        outsideScene.SetActive(false);

        factoryScene.SetActive(true);

        a.Play("Enlarge");
    }
}
