using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;
public class ActivateTeleportationRay : MonoBehaviour
{   //��ġ�ִϸ��̼� �� �ڷ���Ʈ�� xr ŰƮ���� �ҷ���
    public GameObject leftTeleportation;
    //public GameObject rightTeleportation;

    public InputActionProperty leftActivation;
    //public InputActionProperty rightActivation;

    public InputActionProperty leftCancel;

    public XRRayInteractor leftRay;

   
    // Start is called before the first frame update
  

    // Update is called once per frame
    void Update()
    {
        bool isLeftRayHovering = leftRay.TryGetHitInfo(out Vector3 leftpos, out Vector3 leftNolmar, out int leftNumber, out bool leftVaild);


        // �¿�Ƽ�긦 �̿��� Ʈ���Ÿ� ���ÿ� �������� left ��ġ �׼��� �ҷ����� �ڵ� !isLeftRayHovering &&�� �ƴ� ���ex uiȭ���ϰ�� bool isLeft rayhovering �� ����
        leftTeleportation.SetActive(!isLeftRayHovering && leftCancel.action.ReadValue<float>() == 0&& leftActivation.action.ReadValue<float>() > 0.1f);
        
        //�������� �̱��� �޼ո� �ڷ���Ʈ 
        //rightTeleportation.SetActive(rightActivation.action.ReadValue<float>() > 0.1f);


    }
}
