using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XRStackable : MonoBehaviour
{
    private XRStackable currentStackable;
    private XRStackable stackedParent;
    private XRIngredientGrabbable ingredientGrabbable;
    private Rigidbody rb;
    private List<Collider> colliders;
    [SerializeField] private Vector3 offset;
    [SerializeField] private bool isBottomPiece;
    private void Start()
    {
        ingredientGrabbable = GetComponent<XRIngredientGrabbable>();
        ingredientGrabbable.selectEntered.AddListener(RemoveFromParent);
        rb = GetComponent<Rigidbody>();
        colliders = GetComponents<Collider>().ToList();
    }

    private void RemoveFromParent(SelectEnterEventArgs arg0)
    {
        if (stackedParent != null)
        {
            stackedParent.IgnoreCollision(stackedParent.currentStackable, false);
            transform.SetParent(null);
            stackedParent.currentStackable = null;
            stackedParent = null;
            rb.isKinematic = false;
            rb.useGravity = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (currentStackable != null || other.GetComponent<XRStackable>() == stackedParent) return;

        if (other.TryGetComponent(out XRStackable stackable) && other.TryGetComponent(out XRIngredientGrabbable ingredientGrabbable))
        {
            if (!ingredientGrabbable.isGrabbed || stackable.isBottomPiece) return;
            currentStackable = stackable;
            currentStackable.ingredientGrabbable.enabled = false;
            currentStackable.rb.isKinematic = true;
            currentStackable.rb.useGravity = false;
            currentStackable.stackedParent = this;
            currentStackable.transform.SetParent(transform);
            currentStackable.transform.rotation = Quaternion.identity;
            currentStackable.transform.localPosition = currentStackable.offset;
            currentStackable.ingredientGrabbable.enabled = true;
            IgnoreCollision(currentStackable, true);
        }
    }

    private void IgnoreCollision(XRStackable stackable, bool ignore)
    {
        var myColliders = colliders;
        foreach (var myCollider in myColliders)
        {
            foreach (var interactableCollider in stackable.colliders)
            {
                Debug.Log("Ignoring collision for: " + myCollider.gameObject.name + " " + interactableCollider.gameObject.name);
                Physics.IgnoreCollision(myCollider, interactableCollider, ignore);
            }
        }
    }
}
