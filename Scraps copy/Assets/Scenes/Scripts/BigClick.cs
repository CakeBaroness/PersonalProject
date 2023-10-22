using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class BigClick : MonoBehaviour
{
    public GameObject Pickups;

    void Awake()
    {
        Pickups = GetComponent<GameObject>();
    }

    private void OnMouseDown()
    {
        print("clickbitch");
        CollectableInventory storage = gameObject.GetComponent<CollectableInventory>();

        if (storage != null)
        {
            storage.PickupsCollected();
            gameObject.SetActive(false);
        }
    }
}