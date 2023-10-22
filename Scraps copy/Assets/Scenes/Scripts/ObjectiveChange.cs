using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ObjectiveChange : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject ObjectiveText;
    public GameObject ObjectiveChangeText;
    public List<string> Collectables;

    void Start()
    {
        Collectables = new List<string>();
        ObjectiveText.SetActive(true);
        ObjectiveChangeText.SetActive(false);
    }

    public void UpdateObjectiveText(Inventory storage)
    {
        if (storage.CompareTag("Collectables"))
        {
            string itemType = storage.gameObject.GetComponent<CollectableScript>().itemType;
        }
        if (storage.NumberofPickups == 1)
        {
            ObjectiveText.SetActive(false);
            ObjectiveChangeText.SetActive(true);
        }
    }

    //void Update()
    //{

        //ObjectiveText.SetActive(false);
        //ObjectiveText.SetActive(true);
    //}
}
