using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class ObjectDisappear : MonoBehaviour
{
    public GameObject uiElement; // Ȱ��ȭ��ų UI ��Ҹ� ����Ű�� ����
    public XRSimpleInteractable[] Fwood;

   
    private void SetFwoodObjectsEnabled(bool enabled)
    {
      uiElement.SetActive(true);
    }
}