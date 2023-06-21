using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XRinterrectableF : XRBaseInteractable
{
    public GameObject treeObject;

    protected override void OnSelectEntered(XRBaseInteractor interactor)
    {
        base.OnSelectEntered(interactor);

        treeObject.SetActive(true);
    }
}
