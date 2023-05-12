using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public GameObject prompt;
    public TextMeshProUGUI textMesh;

    private ArrayList cache = new ArrayList();

    public void cacheDialogue (string text)
    {
        cache.Add(text);
    }

    public void nextPrompt ()
    {
        if ( cache.Count == 0)
        {
            closePrompt(false);
        }
            else
        {
            if (!prompt.activeSelf)
            {
                prompt.SetActive(true);
            }

            textMesh.SetText((string) cache[0]);
            cache.RemoveAt(0);
        }
    }

    public void closePrompt(bool eraseCache)
    {
        if (eraseCache)
        {
            cache = new ArrayList();
        }

        prompt.SetActive(false);
    }
}
