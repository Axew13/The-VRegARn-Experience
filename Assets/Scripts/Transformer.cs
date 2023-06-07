using UnityEngine;

/*
 * There are probably better ways to do this, but this is
 * a class to make it so that the object is the right size
 * in-game. It has to be really small due to restrictions on
 * Vuforia's Image Targets, but small is difficult to work
 * with in the editor, so I made it bigger in the editor
 * but this script will change it to its necessary size
 * for the game.
 */
public class Transformer : MonoBehaviour
{
    public Vector3 newScale;

    public bool animating;

    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.transform.localScale = newScale;
    }
}
