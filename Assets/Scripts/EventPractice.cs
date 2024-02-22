
using UnityEngine;
using UnityEngine.Events;

public class EventPractice : MonoBehaviour
{
   public UnityEvent testEvent = new UnityEvent();
    // Start is called before the first frame update
    void Start()
    {
        //when event is invoked or raised test listener function will be called.
        testEvent.AddListener(TestListener); 
    }

    // Update is called once per frame
    void Update()
    {
        //when enter key is pressed test listener called pops up
        if (Input.GetKeyDown(KeyCode.Return))
        {
            testEvent.Invoke();
        }
    }
    //when testEvent hppens listener gets called
    void TestListener()
    {
        print("test listener called");
    }
}
