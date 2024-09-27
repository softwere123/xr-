using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

//1. animator에 hand animator 불러온다 2.  헨드에니메이터 셋함수로  이프는 트리거 플로트 함수는 트리거로만든다
public class AnimateHandInputLefthand : MonoBehaviour
{
    public InputActionProperty pinchAnimaitionAction;
    public InputActionProperty gripAnimationAction;
    public Animator handanimator; //< 왜여기서는 에니메이토에서 헨드에니메이토를 만드는데 점을 안쓰지?
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float trigerValue = pinchAnimaitionAction.action.ReadValue<float>(); //<float>() 이거 매게변수 받는거 프로트 옆에 <> 옆에왜 붙어있음?
        //Debug.Log(trigerValue);
        handanimator.SetFloat("Trigger",trigerValue );
        
        float gripValue = gripAnimationAction.action.ReadValue<float>();
        handanimator.SetFloat("Grip", gripValue);

    }
}
