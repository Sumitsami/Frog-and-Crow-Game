using UnityEngine;

public class ActivateDialog : MonoBehaviour
{
    // Set this to the textbox you want to activate when a collision is dectected
    public GameObject DialogueBox;
    // Make sure to attach this script to a game object with a collider!
    private Collider2D getCollider;

    private void Start()
    {
        if (DialogueBox.activeSelf) DialogueBox.SetActive(false);
        getCollider = GetComponent<Collider2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        DialogueBox.SetActive(true);
    }
}
