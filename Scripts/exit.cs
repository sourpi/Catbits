using UnityEngine;

public class exit : MonoBehaviour
{
    private GameObject currentTeleporterr;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("exit"))
        {
            FindObjectOfType<GameManager>().EndGame();

        }
    }

}