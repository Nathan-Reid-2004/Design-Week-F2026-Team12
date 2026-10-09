using Unity.VisualScripting;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class MapMovement : MonoBehaviour
{
    bool isOver1;

    public int itemCount;
    public int smallItemCount;
    public int medItemCount;
    public int largeItemCount;

    public Canvas inventoryScreen;

    public TextMeshPro smallItemCounter;
    public Button smallItemDrop1;
    public Button smallItemDrop2;
    public Button smallItemDrop3;

    public TextMeshPro medItemCounter;
    public Button medItemDrop1;
    public Button medItemDrop2;
    public Button medItemDrop3;

    public TextMeshPro largeItemCounter;
    public Button largeItemDrop1;
    public Button largeItemDrop2;

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
    public Button yesButton4;
    public Button noButton4;
    public Button yesButton5;
    public Button noButton5;
    public Button yesButton6;
    public Button noButton6;
    public Button yesButton7;
    public Button noButton7;
    public Button yesButton8;
    public Button noButton8;

    public GameObject smallItem1;
    public GameObject smallItem2;
    public GameObject smallItem3;
    public GameObject medItem1;
    public GameObject medItem2;
    public GameObject medItem3;
    public GameObject largeItem1;
    public GameObject largeItem2;


    public GameObject smallItemIcon1;
    public GameObject smallItemIcon2;
    public GameObject smallItemIcon3;

    public GameObject medItemIcon1;
    public GameObject medItemIcon2;
    public GameObject medItemIcon3;

    public GameObject largeItemIcon1;
    public GameObject largeItemIcon2;

    public GameObject positionTracker;
    public GameObject locationNodeHospital;
    public GameObject locationNodeLibrary;
    public GameObject locationNodeFactory;

    bool loadItems;
    public GameObject[] loadLibrary = new GameObject[8];
    public GameObject[] loadHospital = new GameObject[7];
    public GameObject[] loadFactory = new GameObject[6];



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isOver1 = false;

        SetSceneLibrary(loadLibrary, false);
        itemCounter.text = ($"Items: {itemCount}");
        smallItemCounter.text = ($"Quantity: {smallItemCount}");
        medItemCounter.text = ($"Quantity: {medItemCount}");
        largeItemCounter.text = ($"Quantity: {largeItemCount}");
        yesButton.gameObject.SetActive(false);
        noButton.gameObject.SetActive(false);
        yesButton2.gameObject.SetActive(false);
        noButton2.gameObject.SetActive(false);
        yesButton3.gameObject.SetActive(false);
        noButton3.gameObject.SetActive(false);
        yesButton4.gameObject.SetActive(false);
        noButton4.gameObject.SetActive(false);
        yesButton5.gameObject.SetActive(false);
        noButton5.gameObject.SetActive(false);
        yesButton6.gameObject.SetActive(false);
        noButton6.gameObject.SetActive(false);
        yesButton7.gameObject.SetActive(false);
        noButton7.gameObject.SetActive(false);
        yesButton8.gameObject.SetActive(false);
        noButton8.gameObject.SetActive(false);
        smallItemIcon1.SetActive(false);
        smallItemIcon2.SetActive(false);
        smallItemIcon3.SetActive(false);
        medItemIcon1.SetActive(false);
        medItemIcon2.SetActive(false);
        medItemIcon3.SetActive(false);
        largeItemIcon1.SetActive(false);
        largeItemIcon2.SetActive(false);
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

        if (smallItemCount > 1 || medItemCount > 1 || largeItemCount > 1)
        {
            isOver1 = true;
            //energy bar depletes

        }
        else
        {
            //energy bar does not deplete
            isOver1 = false;
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

    public void InteractionButtonsItem4()
    {
        sceneDesc.text = "Obtain the item?";
        yesButton4.gameObject.SetActive(true);
        noButton4.gameObject.SetActive(true);
    }

    public void InteractionButtonsItem5()
    {
        sceneDesc.text = "Obtain the item?";
        yesButton5.gameObject.SetActive(true);
        noButton5.gameObject.SetActive(true);
    }

    public void InteractionButtonsItem6()
    {
        sceneDesc.text = "Obtain the item?";
        yesButton6.gameObject.SetActive(true);
        noButton6.gameObject.SetActive(true);
    }

    public void InteractionButtonsItem7()
    {
        sceneDesc.text = "Obtain the item?";
        yesButton7.gameObject.SetActive(true);
        noButton7.gameObject.SetActive(true);
    }

    public void InteractionButtonsItem8()
    {
        sceneDesc.text = "Obtain the item?";
        yesButton8.gameObject.SetActive(true);
        noButton8.gameObject.SetActive(true);
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
        yesButton4.gameObject.SetActive(false);
        noButton4.gameObject.SetActive(false);
        yesButton5.gameObject.SetActive(false);
        noButton5.gameObject.SetActive(false);
        yesButton6.gameObject.SetActive(false);
        noButton6.gameObject.SetActive(false);
        yesButton7.gameObject.SetActive(false);
        noButton7.gameObject.SetActive(false);
        yesButton8.gameObject.SetActive(false);
        noButton8.gameObject.SetActive(false);

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
        yesButton4.gameObject.SetActive(false);
        noButton4.gameObject.SetActive(false);
        yesButton5.gameObject.SetActive(false);
        noButton5.gameObject.SetActive(false);
        yesButton6.gameObject.SetActive(false);
        noButton6.gameObject.SetActive(false);
        yesButton7.gameObject.SetActive(false);
        noButton7.gameObject.SetActive(false);
        yesButton8.gameObject.SetActive(false);
        noButton8.gameObject.SetActive(false);

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
        yesButton4.gameObject.SetActive(false);
        noButton4.gameObject.SetActive(false);
        yesButton5.gameObject.SetActive(false);
        noButton5.gameObject.SetActive(false);
        yesButton6.gameObject.SetActive(false);
        noButton6.gameObject.SetActive(false);
        yesButton7.gameObject.SetActive(false);
        noButton7.gameObject.SetActive(false);
        yesButton8.gameObject.SetActive(false);
        noButton8.gameObject.SetActive(false);

        Destroy(smallItem3);

    }
    public void ItemManagerUp4()
    {
        itemCount += 1;
        itemCounter.text = ($"Items: {itemCount}");
        sceneDesc.text = "You obtained the item.";
        medItemCount += 1;
        medItemCounter.text = ($"Quantity: {medItemCount}");
        medItemIcon1.SetActive(true);
        yesButton.gameObject.SetActive(false);
        noButton.gameObject.SetActive(false);
        yesButton2.gameObject.SetActive(false);
        noButton2.gameObject.SetActive(false);
        yesButton3.gameObject.SetActive(false);
        noButton3.gameObject.SetActive(false);
        yesButton4.gameObject.SetActive(false);
        noButton4.gameObject.SetActive(false);
        yesButton5.gameObject.SetActive(false);
        noButton5.gameObject.SetActive(false);
        yesButton6.gameObject.SetActive(false);
        noButton6.gameObject.SetActive(false);
        yesButton7.gameObject.SetActive(false);
        noButton7.gameObject.SetActive(false);
        yesButton8.gameObject.SetActive(false);
        noButton8.gameObject.SetActive(false);

        Destroy(medItem1);

    }

    public void ItemManagerUp5()
    {
        itemCount += 1;
        itemCounter.text = ($"Items: {itemCount}");
        sceneDesc.text = "You obtained the item.";
        medItemCount += 1;
        medItemCounter.text = ($"Quantity: {medItemCount}");
        medItemIcon2.SetActive(true);
        yesButton.gameObject.SetActive(false);
        noButton.gameObject.SetActive(false);
        yesButton2.gameObject.SetActive(false);
        noButton2.gameObject.SetActive(false);
        yesButton3.gameObject.SetActive(false);
        noButton3.gameObject.SetActive(false);
        yesButton4.gameObject.SetActive(false);
        noButton4.gameObject.SetActive(false);
        yesButton5.gameObject.SetActive(false);
        noButton5.gameObject.SetActive(false);
        yesButton6.gameObject.SetActive(false);
        noButton6.gameObject.SetActive(false);
        yesButton7.gameObject.SetActive(false);
        noButton7.gameObject.SetActive(false);
        yesButton8.gameObject.SetActive(false);
        noButton8.gameObject.SetActive(false);

        Destroy(medItem2);

    }

    public void ItemManagerUp6()
    {
        itemCount += 1;
        itemCounter.text = ($"Items: {itemCount}");
        sceneDesc.text = "You obtained the item.";
        medItemCount += 1;
        medItemCounter.text = ($"Quantity: {medItemCount}");
        medItemIcon3.SetActive(true);
        yesButton.gameObject.SetActive(false);
        noButton.gameObject.SetActive(false);
        yesButton2.gameObject.SetActive(false);
        noButton2.gameObject.SetActive(false);
        yesButton3.gameObject.SetActive(false);
        noButton3.gameObject.SetActive(false);
        yesButton4.gameObject.SetActive(false);
        noButton4.gameObject.SetActive(false);
        yesButton5.gameObject.SetActive(false);
        noButton5.gameObject.SetActive(false);
        yesButton6.gameObject.SetActive(false);
        noButton6.gameObject.SetActive(false);
        yesButton7.gameObject.SetActive(false);
        noButton7.gameObject.SetActive(false);
        yesButton8.gameObject.SetActive(false);
        noButton8.gameObject.SetActive(false);

        Destroy(medItem3);

    }

    public void ItemManagerUp7()
    {
        itemCount += 1;
        itemCounter.text = ($"Items: {itemCount}");
        sceneDesc.text = "You obtained the item.";
        largeItemCount += 1;
        largeItemCounter.text = ($"Quantity: {medItemCount}");
        largeItemIcon1.SetActive(true);
        yesButton.gameObject.SetActive(false);
        noButton.gameObject.SetActive(false);
        yesButton2.gameObject.SetActive(false);
        noButton2.gameObject.SetActive(false);
        yesButton3.gameObject.SetActive(false);
        noButton3.gameObject.SetActive(false);
        yesButton4.gameObject.SetActive(false);
        noButton4.gameObject.SetActive(false);
        yesButton5.gameObject.SetActive(false);
        noButton5.gameObject.SetActive(false);
        yesButton6.gameObject.SetActive(false);
        noButton6.gameObject.SetActive(false);
        yesButton7.gameObject.SetActive(false);
        noButton7.gameObject.SetActive(false);
        yesButton8.gameObject.SetActive(false);
        noButton8.gameObject.SetActive(false);

        Destroy(largeItem1);

    }

    public void ItemManagerUp8()
    {
        itemCount += 1;
        itemCounter.text = ($"Items: {itemCount}");
        sceneDesc.text = "You obtained the item.";
        largeItemCount += 1;
        largeItemCounter.text = ($"Quantity: {medItemCount}");
        largeItemIcon2.SetActive(true);
        yesButton.gameObject.SetActive(false);
        noButton.gameObject.SetActive(false);
        yesButton2.gameObject.SetActive(false);
        noButton2.gameObject.SetActive(false);
        yesButton3.gameObject.SetActive(false);
        noButton3.gameObject.SetActive(false);
        yesButton4.gameObject.SetActive(false);
        noButton4.gameObject.SetActive(false);
        yesButton5.gameObject.SetActive(false);
        noButton5.gameObject.SetActive(false);
        yesButton6.gameObject.SetActive(false);
        noButton6.gameObject.SetActive(false);
        yesButton7.gameObject.SetActive(false);
        noButton7.gameObject.SetActive(false);
        yesButton8.gameObject.SetActive(false);
        noButton8.gameObject.SetActive(false);

        Destroy(largeItem2);

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

    public void ItemDropMed()
    {
        itemCount -= 1;
        itemCounter.text = ($"Items: {itemCount}");
        medItemCount -= 1;
        medItemCounter.text = ($"Quantity: {medItemCount}");
        medItemIcon1.SetActive(false);
    }

    public void ItemDropMed2()
    {
        itemCount -= 1;
        itemCounter.text = ($"Items: {itemCount}");
        medItemCount -= 1;
        medItemCounter.text = ($"Quantity: {medItemCount}");
        medItemIcon2.SetActive(false);
    }

    public void ItemDropMed3()
    {
        itemCount -= 1;
        itemCounter.text = ($"Items: {itemCount}");
        medItemCount -= 1;
        medItemCounter.text = ($"Quantity: {medItemCount}");
        medItemIcon3.SetActive(false);
    }

    public void ItemDropLarge()
    {
        itemCount -= 1;
        itemCounter.text = ($"Items: {itemCount}");
        largeItemCount -= 1;
        largeItemCounter.text = ($"Quantity: {largeItemCount}");
        largeItemIcon1.SetActive(false);
    }

    public void ItemDropLarge2()
    {
        itemCount -= 1;
        itemCounter.text = ($"Items: {itemCount}");
        largeItemCount -= 1;
        largeItemCounter.text = ($"Quantity: {largeItemCount}");
        largeItemIcon2.SetActive(false);
    }

    public void MapPositionChangeHospital()
    {

        positionTracker.transform.position = locationNodeHospital.transform.position;
        sceneDesc.text = "Hospital text";

        SetSceneLibrary(loadLibrary, false);
        SetSceneFactory(loadFactory, false);
        SetSceneHospital(loadHospital, true);

    }

    public void MapPositionChangeLibrary()
    {
        positionTracker.transform.position = locationNodeLibrary.transform.position;
        sceneDesc.text = "Library text";

        SetSceneLibrary(loadLibrary, true);
        SetSceneFactory(loadFactory, false);
        SetSceneHospital(loadHospital, false);
        
    }

    public void MapPositionChangeFactory()
    {
        positionTracker.transform.position = locationNodeLibrary.transform.position;
        sceneDesc.text = "Factory text";

        SetSceneLibrary(loadLibrary, false);
        SetSceneFactory(loadFactory, true);
        SetSceneHospital(loadHospital, false);

    }

    public void SetSceneLibrary(GameObject[] loadLibrary, bool loadItems)
    {
        foreach (GameObject nodes in loadLibrary)
        {
            if (nodes != null)
            {
                nodes.SetActive(loadItems);
            }
        }
    }

    public void SetSceneHospital(GameObject[] loadHospital, bool loadItems)
    {
        foreach (GameObject nodes in loadHospital)
        {
            if (nodes != null)
            {
                nodes.SetActive(loadItems);
            }
        }
    }

    public void SetSceneFactory(GameObject[] loadFactory, bool loadItems)
    {
        foreach (GameObject nodes in loadFactory)
        {
            if (nodes != null)
            {
                nodes.SetActive(loadItems);
            }
        }
    }

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
