using UnityEngine;

public class Factory : Raycastable
{
    public override void Interact()
    {
        DialogueEventManager dem = GetDialogueEventManager();
        dem.swapScenes();

        DialogueManager dm = GetDialogueManager();
        dm.ClosePrompt(true);
        dm.CacheDialogueFromFile("FactoryEnter");
        dm.NextPrompt();
    }
}
