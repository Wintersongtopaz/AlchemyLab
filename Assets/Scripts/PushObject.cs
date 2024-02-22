using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PushObject : MonoBehaviour
{
    private Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()

    // Allows the script to have a rigidbody component with the gameobject it's attached to.
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    public void Push(float strength)
    // Determines the direction, force, and the strength of the push the player uses on a gameobject.
    {
        Vector3 pushDirection = transform.position - Camera.main.transform.position;
        pushDirection.Normalize();

        rigidbody.AddForce(pushDirection * strength, ForceMode.Impulse);
    }
}
