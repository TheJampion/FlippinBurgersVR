using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XRIngredientSocketInteractor : XRSocketInteractor
{
   /*This allows other food to stack with it
    **Reqs:
    *   - Once a socket is filled, it cannot stack any more so its valid targets should be 0
    *   -Should check to see if it is current stacked with something and disable that from being a valid target
    */
    public List<GameObject> Interactors = new List<GameObject>();
    private Ingredient ingredient;
    private XRGrabInteractable grabInteractable;
    private IXRSelectInteractable parentSocket;
    private Collider socketTrigger;
    [SerializeField]private XRRayInteractor leftHandInteractor, rightHandInteractor;
    private bool isParentGrabbed;

    protected override void Start()
    {
        base.Start();
        selectEntered.AddListener(FoodAttached);
        selectExited.AddListener(FoodDetached);
        ingredient = GetComponentInParent<Ingredient>();
        grabInteractable = GetComponentInParent<XRGrabInteractable>();
        socketTrigger = GetComponent<Collider>();
    }

    private void FoodDetached(SelectExitEventArgs arg0)
    {
        Debug.Log("Select exited", this);
        FoodStackManager.instance.RemoveFromStack(arg0.interactableObject.transform.GetComponent<Ingredient>());
        IgnoreCollision(parentSocket, false);
        parentSocket = null;
        socketTrigger.enabled = true;
    }
    private void FoodAttached(SelectEnterEventArgs arg0)
    {
        parentSocket = arg0.interactableObject;
        if (parentSocket == GetComponentInParent<IXRSelectInteractable>()) return;
        FoodStackManager.instance.AddToStack(parentSocket.transform.GetComponent<Ingredient>(), ingredient);
        IgnoreCollision(parentSocket, true);
        socketTrigger.enabled = false;
    }
    public override bool CanHover(IXRHoverInteractable interactable)
    {
        XRIngredientGrabbable ingredientGrabbable = interactable as XRIngredientGrabbable;
        if(ingredientGrabbable != null)
        {
            return ingredientGrabbable.isGrabbed;
        }
        return base.CanHover(interactable);
    }

    public override bool CanSelect(IXRSelectInteractable interactable)
    {
        XRIngredientGrabbable ingredientGrabbable = interactable as XRIngredientGrabbable;
        if (ingredientGrabbable != null)
        {
            if(ingredientGrabbable.transform.GetComponent<Cookable>() != null)
            {
                if(ingredientGrabbable.transform.GetComponent<Cookable>().foodState != Cookable.FoodState.Cooked)
                return false;
            }
            return ingredientGrabbable.isGrabbed;
        }
        return base.CanSelect(interactable) && interactable.transform.GetComponent<Ingredient>() != null;
    }

    private void IgnoreCollision(IXRSelectInteractable interactable, bool ignore)
    {
        var myColliders = grabInteractable.colliders;
        foreach (var myCollider in myColliders)
        {
            foreach (var interactableCollider in interactable.colliders)
            {
                Debug.Log("Ignoring collision for: " + myCollider.gameObject.name + " " + interactableCollider.gameObject.name);
                Physics.IgnoreCollision(myCollider, interactableCollider, ignore);
            }
        }
    }

    private void Update()
    {
        socketTrigger.enabled = !grabInteractable.isSelected;
    }
}
