using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class selectTargetOnInput : MonoBehaviour
{

    // Creates variables to allow referencing of the events system and the starting game object for the list
    public EventSystem eventSystem;
    public GameObject selectedObject;

    // Creates boolean variable to store if a button is currently selected
    private bool buttonSelected;

    // Update is called once per frame
    void Update () 
    {
        // Checks if a vertical selection key is being pressed and if a button is currently selected
        if (Input.GetAxisRaw ("Vertical") != 0 && buttonSelected == false) 
        {
            // Tells the event system to select the first button on the list 
            eventSystem.SetSelectedGameObject(selectedObject);
            // Stores that a button has been selected
            buttonSelected = true;
        }
    }
    
    // OnDisable is called when the element is disabled
    private void OnDisable()
    {
        // Stores that a button is no longer selected as the menu has been closed
        buttonSelected = false;
    }
}

