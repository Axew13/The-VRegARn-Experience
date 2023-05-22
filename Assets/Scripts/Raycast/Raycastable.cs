using UnityEngine;

public class Raycastable : MonoBehaviour
{
    public virtual void Interact ()
    {
        // This does nothing, replace it in classes that extend this class
        Debug.Log("The object " + gameObject.name + " has a Raycastable script and it was triggered, but no functionality is attached to it.", gameObject);
    }

    /* This is bad practise and shouldn't be here. It uses a slow method, only works in 1 scene,
     * follows the wrong naming convention, and there are probably better ways to do this.
     * But whatever, it's convenient. :sparkles: */
    public DialogueManager GetDialogueManager ()
    {
        return GameObject.Find("SceneScripts").GetComponent<DialogueManager>();
    }

    // Same goes for this
    public GameStateManager GetStateManager()
    {
        return GameObject.Find("SceneScripts").GetComponent<GameStateManager>();
    }

}
