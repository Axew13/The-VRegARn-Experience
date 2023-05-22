using UnityEngine;

public class Cow : Raycastable
{
    public override void Interact()
    {
        GameStateManager sm = GetStateManager();
        if (!sm.cowInteracted)
        {
            DialogueManager dm = GetDialogueManager();

            dm.ClosePrompt(true);
            dm.CacheDialogueFromFile("CowInteract");
            dm.NextPrompt();

            sm.cowInteracted = true;

/*          // This would disable it for the selected cow. Find a way to do it for all cows.
            this.gameObject.GetComponent<Collider>().enabled = false;*/
        }
    }
}
