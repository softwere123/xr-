using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameMenuManager : MonoBehaviour
{  
    //메뉴 열었을떄 
    public Transform head;
    public float SpanwDistance = 2;
    public GameObject menu;
    public InputActionProperty showButton;

    // Update is called once per frame
    void Update()
    {
        if(showButton.action.WasPressedThisFrame())
        {
            menu.SetActive(!menu.activeSelf);
            
            menu.transform.position = head.position + new Vector3(head.forward.x, 0, head.position.z).normalized * SpanwDistance;

        }
 
        menu.transform.LookAt(new Vector3(head.forward.x, menu.transform.position.y ,head.forward.z));
        menu.transform.forward *= -1;
    }
}
