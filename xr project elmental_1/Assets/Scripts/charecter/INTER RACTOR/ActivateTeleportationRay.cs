using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;
public class ActivateTeleportationRay : MonoBehaviour
{   //핀치애니메이션 및 텔레포트들 xr 키트에서 불러옴
    public GameObject leftTeleportation;
    //public GameObject rightTeleportation;

    public InputActionProperty leftActivate;
    //public InputActionProperty rightActivation;

    public InputActionProperty leftCancel;
    //public InputActionProperty rightCancel;

    public XRRayInteractor leftRay;
    //public XRRayInteractor rightRay;



    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        bool isLeftRayHovering = leftRay.TryGetHitInfo(out Vector3 leftPos, out Vector3 leftNolmar, out int leftNumber, out bool leftVaild);


        // 셋엑티브를 이용해 트리거를 동시에 눌렀을때 left 핀치 액션을 불러오는 코드 !isLeftRayHovering &&은 아닐 경우ex ui화면일경우 bool isLeft rayhovering 을 적용
        leftTeleportation.SetActive(!isLeftRayHovering && leftCancel.action.ReadValue<float>() == 0 && leftActivate.action.ReadValue<float>() > 0.1f);
        
        //오른손은 미구현 왼손만 텔레포트 
        //rightTeleportation.SetActive(rightActivation.action.ReadValue<float>() > 0.1f);


    }
}
