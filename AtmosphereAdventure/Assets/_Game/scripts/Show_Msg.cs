using UnityEngine;

public class ShowMessage : MonoBehaviour
{
    public GameObject messageObject;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            messageObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            messageObject.SetActive(false);
        }
    }
}