using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallBackSystem : MonoBehaviour
{
    public delegate void OnMessageReceive(); // declaration of delegate
    // void function name no paramaters = signature
    // Start is called before the first frame update
    public event OnMessageReceive onComplete;
    void Start()
    {
        //OnMessageReceive test = WriteMessage; // reference of delegate
        //                                      // because delegate signature matches
        //test(); // calling delegate like a normal function :O
        //        // basically it's calling a method that is assigned to "test"
        onComplete += WriteMessage; // += adds a method

        onComplete();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void WriteMessage()
    {
        Debug.Log("WriteMessage() called");
    }
}
