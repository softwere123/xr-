//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.XR.Interaction.Toolkit;

//public class XRInteractableEventExample : XRBaseInteractable
//{
//    public RobotController11 robotController;

//    protected override void OnSelectEntered(XRBaseInteractor interactor)
//    {
//        base.OnSelectEntered(interactor);

//        // 로봇 컨트롤러가 활성화되었을 때만 SetActive(true) 호출
//        if (robotController != null && robotController.enabled)
//        {
//            robotController.SetActive(true);
//        }
//    }
//}
