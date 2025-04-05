using UnityEngine;
using Yarn.Unity;

public class StartDialogueButton : MonoBehaviour
{
    public DialogueRunner dialogueRunner;  // Drag your DialogueRunner here
    public string startNode = ""; // Optional: Set the node you want to start with

    public void StartDialogue()
    {
        if (dialogueRunner != null)
        {
            if (!string.IsNullOrEmpty(startNode))
                dialogueRunner.StartDialogue(startNode);
            
        }
        else
        {
            Debug.LogError("DialogueRunner not assigned.");
        }
    }
}
