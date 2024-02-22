
using UnityEngine;
using UnityEngine.Events;

public class InteractionObject : MonoBehaviour
{
    [SerializeField] private string interactionText = "I'm an interactable object!";
    // when e key is pressed event will be invoked 
    public UnityEvent OnInteract = new UnityEvent();

    private void OnEnable()
    {
        
    }
    // text will show when facing object
    public string GetInteractionText()
    {
        return interactionText;
    }

    public void Interact()
    {
        OnInteract.Invoke();
    }
}
