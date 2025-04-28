using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class XRSocketInteractorTag : UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor
{
    public string targetTag;

    public override bool CanSelect(UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable interactable)
    { 
        return base.CanSelect(interactable) && interactable.CompareTag(targetTag);
    }
}