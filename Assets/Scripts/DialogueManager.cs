using System.Collections;
using UnityEngine;
using TMPro;
using System;
//using System.IO;
using System.Text.RegularExpressions;

public class DialogueManager : MonoBehaviour
{
    public GameObject prompt;
    public TextMeshProUGUI textMesh;
    // Bad and not scalable, but will do with the time constraints
    public Popup popup;

    private ArrayList cache = new ArrayList();

    // Store an individual line. Pretty annoying to add multiple lines with
    public void CacheDialogue (string text)
    {
        cache.Add(text);
    }

    // Search for lines from txt files in a "Text" folder and store them
    public void CacheDialogueFromFile (string textFile)
    {
        try
        {
            // New functionality which works on build including APKs

            TextAsset textFileObject = Resources.Load(textFile) as TextAsset;

            string fs = textFileObject.text;
            string[] lines = Regex.Split(fs, "\r\n|\n|\r");

            for (int lnNo = 0; lnNo < lines.Length; lnNo++)
            {
                cache.Add(lines[lnNo]);
            }
        }
            catch (Exception ex)
        {
            // Just in case things still don't work
            cache.Add("Error: " + ex.Message);
        }
    }

    // Run special code based on the content of lines
    public void runEvent (string percentEvent) {

    }

    // Display stored lines on-screen
    public void NextPrompt ()
    {
        if ( cache.Count == 0)
        {
            // If cache of lines is empty, close the dialogue box
            ClosePrompt(false);
        }
            else
        {
            string ln = (string) cache[0];
            cache.RemoveAt(0);

            if (ln.StartsWith("%"))
            {
                // If next line is an event to run, run it and skip to the next line
                runEvent(ln);
                NextPrompt();
            }
                else
            {
                if (!prompt.activeSelf)
                {
                    // If the dialogue box is closed, open it
                    prompt.SetActive(true);
                }

                textMesh.SetText(ln);
            }
        }
    }

    // Close the dialogue box. Not necessary to run unless you want to interrupt stored lines. The current line will be erased
    public void ClosePrompt(bool eraseCache)
    {
        // Putting this here for total convenience sake. Given more time to work on this, popup and dialogue management should be moved into the same class
        popup.ClosePopup();

        if (eraseCache)
        {
            cache = new ArrayList();
        }

        prompt.SetActive(false);
    }
}
