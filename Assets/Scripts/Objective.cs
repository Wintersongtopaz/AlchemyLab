using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Objective : MonoBehaviour
{
    [SerializeField]private Text objectiveDisplay;

    [SerializeField] private string objectiveText = "I am an objective!";
    [SerializeField] private string completedText = "Wahoo you've completed an objective!";
    //sets new objective
    public UnityEvent OnCompleteObjective = new UnityEvent();

    // called when the object become enabled and active
    private void OnEnable()
    { 
        objectiveDisplay.text = objectiveText;
    }
    // when objective is complete sets new objective
    public void CompleteObjective()
    {
        if (gameObject.activeSelf)
        {

            objectiveDisplay.text = "";
            
            OnCompleteObjective.Invoke();
             
            gameObject.SetActive(false);
        }
    }
}
