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
    public XRSimpleInteractable[] Fwood;
    public XRSimpleInteractable[] Wfire;

    //public GameObject dropdownObject;// XRSimpleInteractable 오브젝트의 배열

    // SetTypeFromIndex 메서드를 사용하여 인덱스에 따라 오브젝트 변경
    public void SetTypeFromIndex(int index)
    {
        if (index == 0)
        {
            fire.enabled = false;
            earth.enabled = true;
            SetFwoodObjectsEnabled(false);
            SetFire(true);
        }
        else if (index == 1)
        {
            fire.enabled = true;
            earth.enabled = false;
            SetFwoodObjectsEnabled(true);
            SetFire(false);
        }
    }

    // Fwood 배열의 모든 오브젝트의 enabled 값을 설정하는 메서드
    private void SetFwoodObjectsEnabled(bool enabled)
    {
        foreach (XRSimpleInteractable fwoodObject in Fwood)
        {
            fwoodObject.enabled = enabled;
        }
    }

    private void SetFire(bool enabled)
    {
        foreach (XRSimpleInteractable WfireObject in Wfire)
        {
            Wfire.enabled = enabled;
        }
    }
}