using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Cookable : MonoBehaviour
{
    public float CookPercentage { get => cookPercentage; set => cookPercentage = CookPercentage; }
    private float cookPercentage;
    public enum FoodState { Raw, Prepped, Cooking, Cooked, Burnt }
    public FoodState foodState;
    private FoodState beforeCookedState;
    public bool isCooking;
    private float cookTime = 8f;
    [SerializeField] private Slider cookBar;
    [SerializeField] private ParticleSystem cookVFX;
    private Color foodColor;
    private MeshRenderer meshRenderer;

    private float cookTimer;
    [SerializeField]
    private UnityEvent prepped, cookingStarted, cookingStopped, cooked, burnt;
    private void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        foodColor = meshRenderer.material.color;
    }
    private void ChangeState(FoodState state)
    {
        //Change state to it's before cooked state if it was cooking and is not cooked/burnt yet
        if ((state == FoodState.Raw || state == FoodState.Prepped)
            && foodState == FoodState.Cooking)
        {
            cookingStopped.Invoke();
            foodState = beforeCookedState;
            return;
        }
        //Run Events depending on which state we're transitioning to
        switch (state)
        {
            case FoodState.Prepped:
                prepped?.Invoke();
                break;
            case FoodState.Cooking:
                cookingStarted?.Invoke();
                if (foodState == FoodState.Raw || foodState == FoodState.Prepped)
                {
                    beforeCookedState = foodState;
                }
                break;
            case FoodState.Burnt:
                burnt?.Invoke();
                break;
            case FoodState.Cooked:
                cooked?.Invoke();
                break;
        }
        foodState = state;
    }
    public void Cook()
    {
        cookTimer += Time.deltaTime;
        float cookFinishValue = Mathf.Clamp(cookTimer / cookTime, 0f, 1f);
        meshRenderer.material.color = new Color(foodColor.r - 0.25f * cookFinishValue, foodColor.g - 0.25f * cookTimer, foodColor.b - 0.25f * cookTimer);

        if (cookBar != null)
        {
            if (!cookBar.gameObject.activeInHierarchy)
            {
                cookBar.gameObject.SetActive(true);
                cookVFX.Play();
            }
        }
        cookBar.value = cookFinishValue;
        if (cookFinishValue >= 1.0f && foodState != FoodState.Cooked && foodState != FoodState.Burnt)
        {
            ChangeState(FoodState.Cooked);
        }
        if (cookTimer >= cookTime * 2 && foodState != FoodState.Burnt)
        {
            meshRenderer.material.color = Color.black;
            ChangeState(FoodState.Burnt);
        }
    }

    private void Update()
    {
        if (isCooking)
        {
            Cook();
        }
        else
        {
            if (cookBar != null)
            {
                if (cookBar.gameObject.activeInHierarchy)
                {
                    cookBar.gameObject.SetActive(false);
                    cookVFX.Stop();
                }
            }
        }
    }
}
