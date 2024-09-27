using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicisRig : MonoBehaviour
{
    //캐릭터 바디콜라이더 임포트 
   
    public Transform playerHead;  
    public Transform leftController;
    public Transform rightController;
    
    public ConfigurableJoint headJoint;
    public ConfigurableJoint rightHendJoint;
    public ConfigurableJoint leftHendJoint; 
    //public CharacterController bodycollider;
    public CapsuleCollider bodycollider;


    //캐릭터 버다 콜라이더 크기 변환 제한
    public float bodyHeigtMin = 0.5f;
    public float bodyHeigtMax = 2;
    // Start is called before the first frame update
    void FixedUpdate()
    {
        //  백터 3에 저장 클레임값을  클레임값은 위에 함수들사용 
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
