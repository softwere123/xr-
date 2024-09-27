using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class ObjectDisappear : MonoBehaviour
{
    public GameObject uiElement; // 활성화시킬 UI 요소를 가리키는 변수
    public XRSimpleInteractable[] Fwood;

   
    private void SetFwoodObjectsEnabled(bool enabled)
    {
      uiElement.SetActive(true);
    }
}