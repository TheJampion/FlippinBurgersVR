using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum HeatLevel { Off, On}
public class HeatedSurface : MonoBehaviour
{
    public HeatLevel heatLevel;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Heatable heatable) && heatLevel == HeatLevel.On)
        {
            heatable.currentHeatedSurface = this;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent(out Heatable heatable))
        {
            heatable.currentHeatedSurface = null;
            if(heatable.currentCookable != null)
            {
                heatable.currentCookable.isCooking = false;
            }
        }
    }
}
