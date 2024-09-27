using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XRGrabInterractableTwoAttach : XRGrabInteractable
{
    // 물체 그랩시 잡히는 위치 받는값
    public Transform leftAttachTransform;
    public Transform rightAttachTransform;

       
    //  물건 잡을시 서로의 값을 덮어쓴다 9~10 위치값들을 
    protected override void OnSelectEntered(SelectEnterEventArgs args) //(SelectEnterEventArgs args) 이 부분이 내가 배운 void는 int x y이런건대  S.E.E args 가 뭐야 ? //아마 컨트롤러 트리거누는게 엔터일거야 잡으려면 엔터를누르잖아 그부분일듯 
    {
        if(args.interactable.transform.CompareTag("LeftHand Controller"))
        {
            attachTransform = leftAttachTransform;
            
        }
        else if(args.interactable.transform.CompareTag("RightHand Controller"))
        {
            rightAttachTransform = rightAttachTransform;
        }
        //이 함수를 통해 상속받은곳에 보낸다? 잘모르겠다 이부분 //물건을 왼손에서 오른손으로 옮길떼 아타취포인트를 자연스럽게 덮어쓴다는거같아
        base.OnSelectEntered(args);
    }


}