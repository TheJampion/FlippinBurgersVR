using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Heatable : MonoBehaviour
{
    public HeatedSurface currentHeatedSurface;
    public Cookable currentCookable;
    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out Cookable cookable) && currentHeatedSurface !=  null){
            currentCookable = cookable;
            cookable.isCooking = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.TryGetComponent(out Cookable cookable)){
            currentCookable = null;
            cookable.isCooking = false;
        }
    }
}