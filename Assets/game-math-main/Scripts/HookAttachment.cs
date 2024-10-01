using UnityEngine;

public class HookAttachment : MonoBehaviour
{
    public bool isAttached = false;  // To track if the hook is attached to the concrete
    private Transform concreteTransform;  // Reference to the concrete object

    void OnTriggerEnter(Collider other)
    {
        // Check if the hook enters the concrete's attachment point
        if (other.CompareTag("Attachedpoint"))
        {
            isAttached = true;  // Mark as attached
            concreteTransform = other.transform;  // Store the concrete's transform
        }
    }

    void Update()
    {
        // If the hook is attached, update the concrete's position to follow the hook
        if (isAttached && concreteTransform != null)
        {
            Vector3 newPosition = transform.position;
            // Set the concrete's position to match the hook's position (or with a slight offset)
            
            newPosition.y -= 3;
            concreteTransform.position = newPosition;

        }
    }
}
