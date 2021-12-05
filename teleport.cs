using UnityEngine;

public class teleport: MonoBehaviour
{    public Animator animator_1;
      [SerializeField] private Transform destination;

    public Transform GetDestination()
    {
        return destination;
        animator_1.SetFloat("key", 3);
       
    }
}