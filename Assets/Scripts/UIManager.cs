using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    [Header("UI Canvas Sheets")]
    [SerializeField] private GameObject m_characterSheet;

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(this.gameObject);
    }

    public void ToggleCharacterSheet(bool isMakeVisible)
    {
        ToggleCanvas(m_characterSheet, isMakeVisible);
    }

    private void ToggleCanvas(GameObject rootObject, bool isMakeVisible)
    {
        //If this manager lacks this sheet, return;
        if (rootObject == null) return;

        //Activate or Deactivate the Canvas object.
        rootObject.SetActive(isMakeVisible);

        //If activating, move to front of canvas objects.
        if (isMakeVisible) rootObject.transform.SetAsLastSibling();

        //Else deactivating, move to back of canvas objects.
        else rootObject.transform.SetAsFirstSibling();
    }
}
