using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlchemySystem : MonoBehaviour
{
    // Variables
    [SerializeField]
    private List<AlchemyRecipe> alchemyRecipes;
    public static AlchemySystem instance;

    // Functions
    public AlchemyElement GetRecipeOutput(AlchemyElement input1, AlchemyElement input2)
    {
        foreach(AlchemyRecipe alchemyRecipe in alchemyRecipes)
        {
            if (alchemyRecipe.input1 == input1)
            {  
                if(alchemyRecipe.input2 == input2)
                {
                    return alchemyRecipe.output;
                }
            }
            else if (alchemyRecipe.input1 == input2)
            {
                if (alchemyRecipe.input2 == input1)
                {
                    return alchemyRecipe.output;
                }
            }
        }
        return null;
    }

    private void Awake()
    {
        if (instance != null) Destroy(this);
        instance = this;
    }
}
