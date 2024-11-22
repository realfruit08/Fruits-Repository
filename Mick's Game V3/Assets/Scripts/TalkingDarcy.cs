using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class TalkingDarcy : MonoBehaviour
{
    bool cantalk = false;
    public DialogueRunner runner;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E) && cantalk)
        {
            runner.Stop();
            runner.StartDialogue("DarcyDialogue");


        }

    }

    private void OnTriggerEnter2D(Collider2D othercollider)
    {
        if (othercollider.gameObject.name == ("Kelsey"))
        {
            cantalk = true;

        }
        else
        {
            cantalk = false;

        }



    }
    void OnTriggerExit2D(Collider2D other)
    {
        cantalk = false;
    }


}