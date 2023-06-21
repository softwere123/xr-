using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XROffsetGrabInteractable : XRGrabInteractable
{
    // 백터 로테이숀 값 저장 나중에 그랩을 풀었을때 불러오는것으로 추정 
    private Vector3 initialLocalPos;
    private Quaternion initialLocalRot;

    void Start()
    {
      
        if(!attachTransform)
        {
            GameObject attachPoint = new GameObject("Offset Grab Pivot");
            attachPoint.transform.SetParent(transform, false);
            attachTransform = attachPoint.transform;
        }
        else
        {
            initialLocalPos = attachTransform.localPosition; ;
            initialLocalRot = attachTransform.localRotation; ;
        }
    }

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        if(args.interactorObject is XRDirectInteractor)
        {
            attachTransform.position = args.interactableObject.transform.position;
            attachTransform.rotation = args.interactableObject.transform.rotation;
        }
        else
        {
            attachTransform.localPosition = initialLocalPos;
            attachTransform.localRotation = initialLocalRot;

        }
        
        


        base.OnSelectEntered(args);
    }
}
