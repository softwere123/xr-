using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicisRig : MonoBehaviour
{
    //ĳ���� �ٵ��ݶ��̴� ����Ʈ 
   
    public Transform playerHead;  
    public Transform leftController;
    public Transform rightController;
    
    public ConfigurableJoint headJoint;
    public ConfigurableJoint rightHendJoint;
    public ConfigurableJoint leftHendJoint; 
    //public CharacterController bodycollider;
    public CapsuleCollider bodycollider;


    //ĳ���� ���� �ݶ��̴� ũ�� ��ȯ ����
    public float bodyHeigtMin = 0.5f;
    public float bodyHeigtMax = 2;
    // Start is called before the first frame update
    void FixedUpdate()
    {
        //  ���� 3�� ���� Ŭ���Ӱ���  Ŭ���Ӱ��� ���� �Լ����� 
        bodycollider.height = Mathf.Clamp(playerHead.localPosition.y, bodyHeigtMin, bodyHeigtMax );
        bodycollider.center = new Vector3(playerHead.localPosition.x, bodycollider.height / 2
       , playerHead.localPosition.z);

        leftHendJoint.targetPosition = leftController.localPosition;
        leftHendJoint.targetRotation= leftController.localRotation;

        rightHendJoint.targetPosition = rightController.localPosition;
        rightHendJoint.targetRotation = rightController.localRotation;

        headJoint.targetPosition = playerHead.localPosition;
    }



    // Update is called once per frame
    
}
