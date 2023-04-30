using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(SpriteRenderer))]
public class AlchemyElementObject : MonoBehaviour
{
    // Variables
    [SerializeField]
    private AlchemyElement alchemyElement;
    private AlchemyElementObject otherAlchemyElementObject;
    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        // Get Components
        spriteRenderer = GetComponent<SpriteRenderer>();

        // Set Components
        spriteRenderer.sprite = alchemyElement.sprite;
    }

    void OnMouseUp()
    {
        if (otherAlchemyElementObject)
        {

            AlchemyElement newAlchemyElement = AlchemySystem.instance.GetRecipeOutput(alchemyElement, otherAlchemyElementObject.alchemyElement);
            if(newAlchemyElement)
            {
                Destroy(otherAlchemyElementObject.gameObject);
                alchemyElement = newAlchemyElement;
                name = alchemyElement.name;
                spriteRenderer.sprite = alchemyElement.sprite;
            }
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<AlchemyElementObject>())
            otherAlchemyElementObject = collision.gameObject.GetComponent<AlchemyElementObject>();
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<AlchemyElementObject>())
            otherAlchemyElementObject = null;
    }
}
