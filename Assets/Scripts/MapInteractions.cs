using Unity.VisualScripting;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class MapMovement : MonoBehaviour
{
    public int itemCount;
    public int smallItemCount;
    public int medItemCount;
    public int largeItemCount;

    public Canvas inventoryScreen;

    public TextMeshPro smallItemCounter;
    public Button smallItemDrop1;
    public Button smallItemDrop2;
    public Button smallItemDrop3;

    public GameObject itemTextShell;
    public TextMeshPro itemCounter;
    public TextMeshPro moneyCounter;
    public TextMeshProUGUI sceneDesc;

    public Button yesButton;
    public Button noButton;
    public Button yesButton2;
    public Button noButton2;
    public Button yesButton3;
    public Button noButton3;

    public GameObject smallItem1;
    public GameObject smallItem2;
    public GameObject smallItem3;

    public GameObject smallItemIcon1;
    public GameObject smallItemIcon2;
    public GameObject smallItemIcon3;

    public GameObject positionTracker;
    public GameObject locationNodeHospital;
    public GameObject locationNodeLibrary;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        itemCounter.text = ($"Items: {itemCount}");
        smallItemCounter.text = ($"Quantity: {smallItemCount}");
        yesButton.gameObject.SetActive(false);
        noButton.gameObject.SetActive(false);
        yesButton2.gameObject.SetActive(false);
        noButton2.gameObject.SetActive(false);
        yesButton3.gameObject.SetActive(false);
        noButton3.gameObject.SetActive(false);
        smallItemIcon1.SetActive(false);
        smallItemIcon2.SetActive(false);
        smallItemIcon3.SetActive(false);
    }
    
    // Update is called once per frame
    void Update()
    {
        if (itemCount < 0)
        {
            itemCount = 0;
            itemCounter.text = ($"Items: {itemCount}");
        }

        if (smallItemCount < 0)
        {
            smallItemCount = 0;
            smallItemCounter.text = ($"Quantity: {smallItemCount}");
        }  
    }

    public void InteractionButtonsItem()
    {
        sceneDesc.text = "Obtain the item?";
        yesButton.gameObject.SetActive(true);
        noButton.gameObject.SetActive(true);
    }

    public void InteractionButtonsItem2()
    {
        sceneDesc.text = "Obtain the item?";
        yesButton2.gameObject.SetActive(true);
        noButton2.gameObject.SetActive(true);
    }

    public void InteractionButtonsItem3()
    {
        sceneDesc.text = "Obtain the item?";
        yesButton3.gameObject.SetActive(true);
        noButton3.gameObject.SetActive(true);
    }

    public void ItemManagerUp()
    {
        itemCount += 1;
        itemCounter.text = ($"Items: {itemCount}");
        sceneDesc.text = "You obtained the item.";
        smallItemCount += 1;
        smallItemCounter.text = ($"Quantity: {smallItemCount}");
        smallItemIcon1.SetActive(true);
        yesButton.gameObject.SetActive(false);
        noButton.gameObject.SetActive(false);
        yesButton2.gameObject.SetActive(false);
        noButton2.gameObject.SetActive(false);
        yesButton3.gameObject.SetActive(false);
        noButton3.gameObject.SetActive(false);

        Destroy(smallItem1);

    }
    
    public void ItemManagerUp2()
    {
        
        itemCount += 1;
        itemCounter.text = ($"Items: {itemCount}");
        sceneDesc.text = "You obtained the item.";
        smallItemCount += 1;
        smallItemCounter.text = ($"Quantity: {smallItemCount}");
        smallItemIcon2.SetActive(true);
        yesButton.gameObject.SetActive(false);
        noButton.gameObject.SetActive(false);
        yesButton2.gameObject.SetActive(false);
        noButton2.gameObject.SetActive(false);
        yesButton3.gameObject.SetActive(false);
        noButton3.gameObject.SetActive(false);

        Destroy(smallItem2);

    }
    
    public void ItemManagerUp3()
    {
        itemCount += 1;
        itemCounter.text = ($"Items: {itemCount}");
        sceneDesc.text = "You obtained the item.";
        smallItemCount += 1;
        smallItemCounter.text = ($"Quantity: {smallItemCount}");
        smallItemIcon3.SetActive(true);
        yesButton.gameObject.SetActive(false);
        noButton.gameObject.SetActive(false);
        yesButton2.gameObject.SetActive(false);
        noButton2.gameObject.SetActive(false);
        yesButton3.gameObject.SetActive(false);
        noButton3.gameObject.SetActive(false);

        Destroy(smallItem3);

    }

    public void ItemManagerDown()
    {
        yesButton.gameObject.SetActive(false);
        noButton.gameObject.SetActive(false);
        yesButton2.gameObject.SetActive(false);
        noButton2.gameObject.SetActive(false);
        yesButton3.gameObject.SetActive(false);
        noButton3.gameObject.SetActive(false);

        sceneDesc.text = "(description of scene)";
    }   

    public void ItemDropSmall()
    {
        itemCount -= 1;
        itemCounter.text = ($"Items: {itemCount}");
        smallItemCount -= 1;
        smallItemCounter.text = ($"Quantity: {smallItemCount}");
        smallItemIcon1.SetActive(false);
    }

    public void ItemDropSmall2()
    {
        itemCount -= 1;
        itemCounter.text = ($"Items: {itemCount}");
        smallItemCount -= 1;
        smallItemCounter.text = ($"Quantity: {smallItemCount}");
        smallItemIcon2.SetActive(false);
    }

    public void ItemDropSmall3()
    {
        itemCount -= 1;
        itemCounter.text = ($"Items: {itemCount}");
        smallItemCount -= 1;
        smallItemCounter.text = ($"Quantity: {smallItemCount}");
        smallItemIcon3.SetActive(false);
    }

    public void MapPositionChangeHospital()
    {

        positionTracker.transform.position = locationNodeHospital.transform.position;

    }

    public void MapPositionChangeLibrary()
    {
        positionTracker.transform.position = locationNodeLibrary.transform.position;
    }

    //remember for home base, have the option to sell items and to purchase jammers

    public void InventoryScreenOpen()
    {
        inventoryScreen.sortingOrder = 100;
        smallItemCounter.sortingOrder = 101;
    }

    public void InventoryScreenClose()
    {
        inventoryScreen.sortingOrder = -100;
        smallItemCounter.sortingOrder = -101;
    }
}
