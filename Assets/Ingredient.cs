using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum IngredientType
{
    BunBottom, BunTop, Burger, Cheese, Lettuce, Tomato
}
public class Ingredient : MonoBehaviour
{
    public IngredientType ingredientType;
}
