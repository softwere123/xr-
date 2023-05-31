using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class Settherobottype : MonoBehaviour 
{
    //public ActionBasedSnapTurnProvider snapturn;
    //public ActionBasedContinuousTurnProvider continiousTurn;
    
    public RobotController10 fire;
    public Earth earth;

    // 턴 방식 바꾸는법
    public void SetTypeFromIndex(int index)
    {
        if(index == 0)
        {
            fire.enabled = false;
            earth.enabled = true;
            
        }
        else if(index == 1)
        {
           
           fire.enabled = true;
            earth.enabled = false;
           
        }

    }

}