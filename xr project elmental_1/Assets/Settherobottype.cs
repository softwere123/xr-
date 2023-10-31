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

    //public GameObject dropdownObject;// XRSimpleInteractable ������Ʈ�� �迭

    // SetTypeFromIndex �޼��带 ����Ͽ� �ε����� ���� ������Ʈ ����
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

    // Fwood �迭�� ��� ������Ʈ�� enabled ���� �����ϴ� �޼���
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