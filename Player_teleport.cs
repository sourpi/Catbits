using UnityEngine;

public class Player_teleport : MonoBehaviour
{
    private GameObject currentTeleporterr;
    public Animator animator_1; 
    public Animator animator_2;
    public Animator animator_3;
        void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {   
            if (currentTeleporterr != null)
            {   
                animator_1.SetFloat("key", 3);
                animator_3.SetFloat("key", 3);
                transform.position = currentTeleporterr.GetComponent<teleport>().GetDestination().position;
                animator_2.SetFloat("PressKey", 3);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("teleport"))
        {
            currentTeleporterr = collision.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("teleport"))
        {
            if (collision.gameObject == currentTeleporterr)
            {
                currentTeleporterr = null;
            }
        }
    }
}