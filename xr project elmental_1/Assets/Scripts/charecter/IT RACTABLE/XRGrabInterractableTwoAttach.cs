using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XRGrabInterractableTwoAttach : XRGrabInteractable
{
    // ��ü �׷��� ������ ��ġ �޴°�
    public Transform leftAttachTransform;
    public Transform rightAttachTransform;

       
    //  ���� ������ ������ ���� ����� 9~10 ��ġ������ 
    protected override void OnSelectEntered(SelectEnterEventArgs args) //(SelectEnterEventArgs args) �� �κ��� ���� ��� void�� int x y�̷��Ǵ�  S.E.E args �� ���� ? //�Ƹ� ��Ʈ�ѷ� Ʈ���Ŵ��°� �����ϰž� �������� ���͸������ݾ� �׺κ��ϵ� 
    {
        if(args.interactable.transform.CompareTag("LeftHand Controller"))
        {
            attachTransform = leftAttachTransform;
            
        }
        else if(args.interactable.transform.CompareTag("RightHand Controller"))
        {
            rightAttachTransform = rightAttachTransform;
        }
        //�� �Լ��� ���� ��ӹ������� ������? �߸𸣰ڴ� �̺κ� //������ �޼տ��� ���������� �ű涼 ��Ÿ������Ʈ�� �ڿ������� ����ٴ°Ű���
        base.OnSelectEntered(args);
    }


}