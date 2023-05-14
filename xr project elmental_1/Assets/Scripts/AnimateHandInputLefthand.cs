using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

//1. animator�� hand animator �ҷ��´� 2.  ��忡�ϸ����� ���Լ���  ������ Ʈ���� �÷�Ʈ �Լ��� Ʈ���ŷθ����
public class AnimateHandInputLefthand : MonoBehaviour
{
    public InputActionProperty pinchAnimaitionAction;
    public InputActionProperty gripAnimationAction;
    public Animator handanimator; //< �ֿ��⼭�� ���ϸ����信�� ��忡�ϸ����並 ����µ� ���� �Ⱦ���?
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float trigerValue = pinchAnimaitionAction.action.ReadValue<float>(); //<float>() �̰� �ŰԺ��� �޴°� ����Ʈ ���� <> ������ �پ�����?
        //Debug.Log(trigerValue);
        handanimator.SetFloat("Trigger",trigerValue );
        
        float gripValue = gripAnimationAction.action.ReadValue<float>();
        handanimator.SetFloat("Grip", gripValue);

    }
}
