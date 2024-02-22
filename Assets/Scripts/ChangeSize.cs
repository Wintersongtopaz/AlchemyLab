using UnityEngine;

public class ChangeSize : MonoBehaviour
{
    [SerializeField] private float modifiedScale = 2f;
    [SerializeField] private float changeRate = 5f;
    private Vector3 initialScale;
    private bool isScaled = false;
    // Start is called before the first frame update
    void Start()
    {
        initialScale = transform.localScale;
    }

    // Change the size of the gameobject with this script at a constant rate.
    // Update is called once per frame
    void Update()
    {
        transform.localScale = Vector3.MoveTowards(transform.localScale, GetTargetScale(), changeRate * Time.deltaTime);
    }

    // When the gameobject reached a certain size, the gameobject with stop growing or shrinking.
    private Vector3 GetTargetScale()
    {
        return isScaled ? Vector3.one * modifiedScale : initialScale;
    }

    public void ToggleScale()
    {
        isScaled = !isScaled;
    }
}
