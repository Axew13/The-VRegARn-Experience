public class Cow : Raycastable
{
    public override void Interact()
    {
        DialogueManager dm = GetDialogueManager();

        dm.ClosePrompt(true);
        dm.CacheDialogueFromFile("CowInteract");
        dm.NextPrompt();
    }
}
