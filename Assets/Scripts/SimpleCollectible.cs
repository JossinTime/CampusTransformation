using TMPro;
using UnityEngine;

public class SimpleCollectible : MonoBehaviour
{
    public string itemName;
    public KeyCode collectKey = KeyCode.E;
    public float collectRange = 1f;
    public TMP_Text collectionPrompt; // Assign in Inspector

    private GameObject player;
    private bool canCollect = false;

    // GUI style for better appearance
    private GUIStyle guiStyle = new GUIStyle();

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        if (collectionPrompt != null)
        {
            collectionPrompt.gameObject.SetActive(false);
        }

        // Set up the GUI style
        guiStyle.fontSize = 20;
        guiStyle.normal.textColor = Color.white;
        guiStyle.alignment = TextAnchor.MiddleCenter;
    }

    void Update()
    {
        float distance = Vector2.Distance(transform.position, player.transform.position);
        canCollect = distance <= collectRange;

        if (canCollect && Input.GetKeyDown(collectKey))
        {
            SimpleInventoryTMP.instance.AddItem(itemName);
            Destroy(gameObject);
        }
    }
    void OnGUI()
    {
        if (canCollect)
        {
            // Calculate bottom center position
            float labelWidth = 300f;
            float labelHeight = 50f;
            float xPos = (Screen.width - labelWidth) / 2f;
            float yPos = Screen.height - labelHeight - 20f; // 20 pixels from bottom

            // Create a background box for better visibility
            GUI.Box(new Rect(xPos - 10, yPos - 10, labelWidth + 20, labelHeight + 20), "");

            // Display the collection prompt
            GUI.Label(new Rect(xPos, yPos, labelWidth, labelHeight),
                     "Press E to collect " + itemName, guiStyle);
        }
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, collectRange);
    }
}