using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class BodyClick : MonoBehaviour
{
    public GameObject Pickup;

    void Awake()
    {
        Pickup = GetComponent<GameObject>();
    }

    private void OnMouseDown()
    {
        print("clicked");
        Inventory storage = gameObject.GetComponent<Inventory>();

        if (storage != null)
        {
            storage.PickupsCollected();
            gameObject.SetActive(false);
        }
    }


    //GameObject GetGameObject (out RaycastHit hit)
    //{
    //GameObject target = null;
    //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    //if (Physics.Raycast(ray.origin, ray.direction * 10, out hit))
    //{
    //if (isPointerOverUIObject())
    //{
    //target = hit.collider.gameObject;
    //}
    //return target;
    //}
    //}

    //private bool isPointerOverUIObject()
    //{
    //PointerEventData ped = new PointerEventData(EventSystem.current);
    //ped.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
    //List<RaycastResult> results = new List<RaycastResult>();
    //EventSystem.current.RaycastAll(ped, results);
    //return results.Count > 0;
    //}
    private void Update()
    {
        //if (Input.GetMouseButtonDown(0))
            //if (Pickup == getClickedObject(out RaycastHit hit))
            //{
                //{
                    //print("clicked");
                    //Inventory inventory = Pickup.GetComponent<Inventory>();

                    //if (inventory != null)
                    //{
                        //inventory.PickupsCollected();
                        //Pickup.SetActive(false);
                    //}
                //}
            //}
    }


    //public void onMouseDown(Inventory other)
    //{
        //Inventory inventory = other.GetComponent<Inventory>();

        //if(inventory != null)
         //{
            //inventory.PickupsCollected();
            //Pickup.SetActive(false);
          //}
    //}

    
}
