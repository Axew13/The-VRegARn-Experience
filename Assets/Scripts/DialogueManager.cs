using System.Collections;
using UnityEngine;
using TMPro;
using System;
using System.IO;

public class DialogueManager : MonoBehaviour
{
    public GameObject prompt;
    public TextMeshProUGUI textMesh;

    private ArrayList cache = new ArrayList();

    // Store an individual line. Pretty annoying to add multiple lines with
    public void cacheDialogue (string text)
    {
        cache.Add(text);
    }

    // Search for lines from txt files in a "Text" folder and store them
    public void cacheDialogueFromFile(string textFile)
    {
        try
        {
            using (StreamReader file = new StreamReader("Text/" + textFile + ".txt"))
            {
                int counter = 0;
                string ln;

                while ((ln = file.ReadLine()) != null)
                {
                    cache.Add(ln);
                    counter++;
                }
                file.Close();
            }
        }
            catch (Exception ex)
        {
            // Just in case things don't work in a build
            cache.Add("Error: " + ex.Message);
        }
    }

    // Run special code based on the content of lines
    public void runEvent (string percentEvent) {

    }

    // Display stored lines on-screen
    public void nextPrompt ()
    {
        if ( cache.Count == 0)
        {
            // If cache of lines is empty, close the dialogue box
            closePrompt(false);
        }
            else
        {
            string ln = (string) cache[0];
            cache.RemoveAt(0);

            if (ln.StartsWith("%"))
            {
                // If next line is an event to run, run it and skip to the next line
                runEvent(ln);
                nextPrompt();
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
    public void closePrompt(bool eraseCache)
    {
        if (eraseCache)
        {
            cache = new ArrayList();
        }

        prompt.SetActive(false);
    }
}
