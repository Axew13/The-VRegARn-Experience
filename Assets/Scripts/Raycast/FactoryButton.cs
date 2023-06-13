using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryButton : Raycastable
{
    public SceneChanger sc;

    public GameObject meatAndCowMilkLine;
    public GameObject oatMilkLine;

    public override void Interact()
    {
        GameStateManager sm = GetStateManager();

        if (!sm.buttonPressed)
        {
            meatAndCowMilkLine.SetActive(false);
            oatMilkLine.SetActive(true);

            DialogueManager dm = GetDialogueManager();

            sm.buttonPressed = true;

            dm.ClosePrompt(true);
            dm.CacheDialogueFromFile("MachineInteract");
            dm.NextPrompt();
        }
    }
}