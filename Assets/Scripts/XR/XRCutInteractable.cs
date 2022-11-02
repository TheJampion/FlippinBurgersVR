using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XRCutInteractable : XRGrabInteractable
{
    private bool readyToCut;
    private Cuttable currentCuttable;
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Cuttable cuttable))
        {
            currentCuttable = cuttable;
            readyToCut = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.TryGetComponent(out Cuttable cuttable))
        {
            currentCuttable.isCutting = false;
            currentCuttable = null;
            readyToCut = false;
        }
    }

    public void StartCutting(ActivateEventArgs args0)
    {
        if (currentCuttable && readyToCut)
        {
            currentCuttable.isCutting = true;
        }
    }

    public void StopCutting(DeactivateEventArgs args0)
    {
        if (currentCuttable)
        {
            currentCuttable.isCutting = false;
        }
    }
}
