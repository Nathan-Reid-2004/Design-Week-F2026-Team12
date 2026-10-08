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

    public TextMeshPro smallItemCounter;

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

    public GameObject positionTracker;
    public GameObject locationNodeHospital;
    public GameObject locationNodeLibrary;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        itemCounter.text = ($"Items: {itemCount}");
        yesButton.gameObject.SetActive(false);
        noButton.gameObject.SetActive(false);
        yesButton2.gameObject.SetActive(false);
        noButton2.gameObject.SetActive(false);
        yesButton3.gameObject.SetActive(false);
        noButton3.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

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

    public void ItemDrop()
    {
        itemCount -= 1;
        itemCounter.text = ($"Items: {itemCount}");
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
        SceneManager.LoadScene("Inventory Screen");
    }
}
