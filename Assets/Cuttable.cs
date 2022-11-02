using Sirenix.Utilities;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cuttable : MonoBehaviour
{
    [SerializeField]
    private ParticleSystem ps;
    [SerializeField]
    private Slider cutBar;
    [SerializeField]
    private float cutTime = 4f;
    [SerializeField]
    private GameObject slicedPrefab;
    private float cutTimer;
    public bool isCutting;

    private void Cut()
    {
        cutTimer += Time.deltaTime;
        float cutFinishValue = Mathf.Clamp(cutTimer / cutTime, 0, 1);

        if (cutBar != null)
        {
            if (!cutBar.gameObject.activeInHierarchy)
            {
                cutBar.gameObject.SetActive(true);
                ps.Play();
            }
            cutBar.value = cutFinishValue;
        }

        if (cutTimer >= cutTime)
        {
            GameObject newIngredient = Instantiate(slicedPrefab, transform.position, Quaternion.identity);
            newIngredient.GetComponentsInChildren<Ingredient>().ForEach(o => FoodStackManager.instance.foodStacks.Add(o, new Stack<Ingredient>()));
            isCutting = false;
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        if (isCutting)
        {
            Cut();
        }
        else
        {
            ps.Stop();
            if (cutBar != null)
            {
                if (cutBar.gameObject.activeInHierarchy)
                {
                    cutBar.gameObject.SetActive(false);
                }
            }
        }
    }
}
