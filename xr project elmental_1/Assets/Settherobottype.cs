using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class Settherobottype : MonoBehaviour 
{
    //public ActionBasedSnapTurnProvider snapturn;
    //public ActionBasedContinuousTurnProvider continiousTurn;
    
    public RobotController11 fire;
    public Earth earth;
    public XRSimpleInteractable Fwood;
    // �� ��� �ٲٴ¹�
    public void SetTypeFromIndex(int index)
    {
        if(index == 0)
        {
            fire.enabled = false;
            earth.enabled = true;
            Fwood.enabled = false;
            
        }
        else if(index == 1)
        {
           
           fire.enabled = true;
            earth.enabled = false;
            Fwood.enabled=true;
        }

    }

}