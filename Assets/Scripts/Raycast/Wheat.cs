public class Wheat : Raycastable
{
    public override void Interact()
    {
        DialogueManager dm = GetDialogueManager();
        GameStateManager sm = GetStateManager();

        dm.ClosePrompt(true);
        
        if (sm.cowInteracted)
        {
            dm.CacheDialogueFromFile("WheatInteract");

            sm.wheatInteracted = true;
        }
            else
        {
            dm.CacheDialogueFromFile("WheatInteractEarly");
        }

        dm.NextPrompt();
    }
}
