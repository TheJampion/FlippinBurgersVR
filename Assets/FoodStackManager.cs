using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class FoodStackManager : MonoBehaviour
{
    [ShowInInspector]
    public Dictionary<Ingredient, Stack<Ingredient>> foodStacks = new Dictionary<Ingredient, Stack<Ingredient>>();

    public static FoodStackManager instance;
    /*This script keeps track of whether a stack has started, and what is in the stack
    **Reqs:
    *   - If an stack has nothing in it, then it is no longer considered a food stack
    */

    private void Awake()
    {
        if(instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }

    private void Start()
    {
        var ingredients = FindObjectsOfType<Ingredient>().ToList();
        ingredients.ForEach(ingredient => foodStacks.Add( ingredient, new Stack<Ingredient>() ) );
    }

    public void AddToStack(Ingredient newIngredient, Ingredient baseIngredient)
    {
        if (!foodStacks.ContainsKey(baseIngredient))
        {
            baseIngredient = foodStacks.First(stack => stack.Value.Contains(baseIngredient)).Key;
        }
        if (foodStacks.ContainsKey(newIngredient))
        {
            int newIngredientStackCount = foodStacks[newIngredient].Count;
            foodStacks[baseIngredient].Push(newIngredient);
            for (int i=0; i < newIngredientStackCount; i++)
            {
                foodStacks[baseIngredient].Push(foodStacks[newIngredient].Pop());
            }
            foodStacks.Remove(newIngredient);
        }
    }

    public void RemoveFromStack(Ingredient ingredient)
    {
        foodStacks.First(stack => stack.Value.Contains(ingredient)).Value.Pop();
        foodStacks.Add(ingredient, new Stack<Ingredient>());
    }
}
