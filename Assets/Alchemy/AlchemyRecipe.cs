using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Recipe", menuName = "Alchemy/Recipe")]
public class AlchemyRecipe : ScriptableObject
{
    public AlchemyElement input1;
    public AlchemyElement input2;
    public AlchemyElement output;
}

