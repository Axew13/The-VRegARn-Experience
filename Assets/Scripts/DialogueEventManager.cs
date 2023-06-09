using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueEventManager : MonoBehaviour
{
    // These are just for the runSceneAppeared method, it should probably be decided what class interacts with both of these on a regular basis
    public GameStateManager gsm;
    public DialogueManager dm;

    public SceneChanger sc;

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
        else if (eventName.Equals("return_to_menu"))
        {
            sc.changeScene(0);
        }
        else if (eventName.Equals("ready_to_interact"))
        {
            gsm.readyToInteract = true;
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
/*
 *      // Unused due to issues, re-add later
 *      
 *      Animator a = transformer.GetComponent<Animator>();
 *      a.Play("Shrink");
 */

        Transformer tfScript = transformer.GetComponent<Transformer>();

        while (tfScript.animating)
        {
            // hold
        }

        outsideScene.SetActive(false);

        factoryScene.SetActive(true);

/*
 *      a.Play("Enlarge");
 */
    }

    public void runSceneAppeared()
    {
        if (!gsm.sceneAppeared)
        {
            dm.ClosePrompt(true);
            dm.CacheDialogueFromFile("OnSceneAppear");
            dm.NextPrompt();

            gsm.sceneAppeared = true;
        }
    }
}
