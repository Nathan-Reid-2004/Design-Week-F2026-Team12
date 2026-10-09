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

    public GameObject leaveNode;
    public GameObject leaveNodeHospital;
    public GameObject leaveNodeLibrary;
    public GameObject leaveNodeFactory;

    bool loadItems;
    public GameObject[] loadOverworld = new GameObject[4];
    public GameObject[] loadLibrary = new GameObject[4];
    public GameObject[] loadHospital = new GameObject[4];
    public GameObject[] loadFactory = new GameObject[3];

    public AudioSource itemPickupSound;
    public AudioSource menuSound;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isOver1 = false;

        positionTracker.transform.position = leaveNode.transform.position;

        sceneDesc.text = "This is 1-topia. A desolate place left in ruin from the upper eschalant of this world. You are a junkrat, a nomad scavenger that relies on what gets left behind to survive, and you alone must search for your means to live. Travel to nearby locations to scavenge and manage your energy so you can overcome this unforgiving place.";

        SetSceneLibrary(loadLibrary, false);
        SetSceneFactory(loadFactory, false);
        SetSceneHospital(loadHospital, false);
        SetSceneOverworld(loadOverworld, true);
        
        itemCounter.text = ($"Items: {itemCount}");
        smallItemCounter.text = ($"Small Item Quantity: {smallItemCount}");
        medItemCounter.text = ($"Med Item Quantity: {medItemCount}");
        largeItemCounter.text = ($"Lrg Item Quantity: {largeItemCount}");
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
            smallItemCounter.text = ($"Small Item Quantity: {smallItemCount}");
        }

        if (medItemCount < 0)
        {
            medItemCount = 0;
            medItemCounter.text = ($"Med Item Quantity: {medItemCount}");
        }

        if (largeItemCount < 0)
        {
            largeItemCount = 0;
            largeItemCounter.text = ($"Lrg Item Quantity: {largeItemCount}");
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
        menuSound.Play();
    }

    public void InteractionButtonsItem2()
    {
        sceneDesc.text = "Obtain the item?";
        yesButton2.gameObject.SetActive(true);
        noButton2.gameObject.SetActive(true);
        menuSound.Play();
    }

    public void InteractionButtonsItem3()
    {
        sceneDesc.text = "Obtain the item?";
        yesButton3.gameObject.SetActive(true);
        noButton3.gameObject.SetActive(true);
        menuSound.Play();
    }

    public void InteractionButtonsItem4()
    {
        sceneDesc.text = "Obtain the item?";
        yesButton4.gameObject.SetActive(true);
        noButton4.gameObject.SetActive(true);
        menuSound.Play();
    }

    public void InteractionButtonsItem5()
    {
        sceneDesc.text = "Obtain the item?";
        yesButton5.gameObject.SetActive(true);
        noButton5.gameObject.SetActive(true);
        menuSound.Play();
    }

    public void InteractionButtonsItem6()
    {
        sceneDesc.text = "Obtain the item?";
        yesButton6.gameObject.SetActive(true);
        noButton6.gameObject.SetActive(true);
        menuSound.Play();
    }

    public void InteractionButtonsItem7()
    {
        sceneDesc.text = "Obtain the item?";
        yesButton7.gameObject.SetActive(true);
        noButton7.gameObject.SetActive(true);
        menuSound.Play();
    }

    public void InteractionButtonsItem8()
    {
        sceneDesc.text = "Obtain the item?";
        yesButton8.gameObject.SetActive(true);
        noButton8.gameObject.SetActive(true);
        menuSound.Play();
    }

    public void ItemManagerUp()
    {
        itemCount += 1;
        itemCounter.text = ($"Items: {itemCount}");
        sceneDesc.text = "You obtained the item.";
        smallItemCount += 1;
        smallItemCounter.text = ($"Small Item Quantity: {smallItemCount}");
        smallItemIcon1.SetActive(true);
        itemPickupSound.Play();
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
        smallItemCounter.text = ($"Small Item Quantity: {smallItemCount}");
        smallItemIcon2.SetActive(true);
        itemPickupSound.Play();
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
        smallItemCounter.text = ($"Small Item Quantity: {smallItemCount}");
        smallItemIcon3.SetActive(true);
        itemPickupSound.Play();
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
        medItemCounter.text = ($"Med Item Quantity: {medItemCount}");
        medItemIcon1.SetActive(true);
        itemPickupSound.Play();
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
        medItemCounter.text = ($"Med Item Quantity: {medItemCount}");
        medItemIcon2.SetActive(true);
        itemPickupSound.Play();
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
        medItemCounter.text = ($"Med Item Quantity: {medItemCount}");
        medItemIcon3.SetActive(true);
        itemPickupSound.Play();
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
        largeItemCounter.text = ($"Lrg Item Quantity: {largeItemCount}");
        largeItemIcon1.SetActive(true);
        itemPickupSound.Play();
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
        largeItemCounter.text = ($"Lrg Item Quantity: {largeItemCount}");
        largeItemIcon2.SetActive(true);
        itemPickupSound.Play();
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
        menuSound.Play();
    }   

    public void ItemDropSmall()
    {

        
            itemCount -= 1;
            itemCounter.text = ($"Items: {itemCount}");
            smallItemCount -= 1;
            smallItemCounter.text = ($"Small Item Quantity: {smallItemCount}");
            smallItemIcon1.SetActive(false);
            smallItemDrop1.enabled = false;
            itemPickupSound.Play();
        
    }

    public void ItemDropSmall2()
    {
        itemCount -= 1;
        itemCounter.text = ($"Items: {itemCount}");
        smallItemCount -= 1;
        smallItemCounter.text = ($"Small Item Quantity: {smallItemCount}");
        smallItemIcon2.SetActive(false);
        smallItemDrop2.enabled = false;
        itemPickupSound.Play();
    }

    public void ItemDropSmall3()
    {
        itemCount -= 1;
        itemCounter.text = ($"Items: {itemCount}");
        smallItemCount -= 1;
        smallItemCounter.text = ($"Small Item Quantity: {smallItemCount}");
        smallItemIcon3.SetActive(false);
        smallItemDrop3.enabled = false;
        itemPickupSound.Play();
    }

    public void ItemDropMed()
    {
        itemCount -= 1;
        itemCounter.text = ($"Items: {itemCount}");
        medItemCount -= 1;
        medItemCounter.text = ($"Med Item Quantity: {medItemCount}");
        medItemIcon1.SetActive(false);
        medItemDrop1.enabled = false;
        itemPickupSound.Play();
    }

    public void ItemDropMed2()
    {
        itemCount -= 1;
        itemCounter.text = ($"Items: {itemCount}");
        medItemCount -= 1;
        medItemCounter.text = ($"Med Item Quantity: {medItemCount}");
        medItemIcon2.SetActive(false);
        medItemDrop2.enabled = false;
        itemPickupSound.Play();
    }

    public void ItemDropMed3()
    {
        itemCount -= 1;
        itemCounter.text = ($"Items: {itemCount}");
        medItemCount -= 1;
        medItemCounter.text = ($"Med Item Quantity: {medItemCount}");
        medItemIcon3.SetActive(false);
        medItemDrop3.enabled = false;
        itemPickupSound.Play();
    }

    public void ItemDropLarge()
    {
        itemCount -= 1;
        itemCounter.text = ($"Items: {itemCount}");
        largeItemCount -= 1;
        largeItemCounter.text = ($"Lrg Item Quantity: {largeItemCount}");
        largeItemIcon1.SetActive(false);
        largeItemDrop1.enabled = false;
        itemPickupSound.Play();
    }

    public void ItemDropLarge2()
    {
        itemCount -= 1;
        itemCounter.text = ($"Items: {itemCount}");
        largeItemCount -= 1;
        largeItemCounter.text = ($"Lrg Item Quantity: {largeItemCount}");
        largeItemIcon2.SetActive(false);
        largeItemDrop2.enabled = false;
        itemPickupSound.Play();
    }

    public void MapPositionChangeHospital()
    {

        positionTracker.transform.position = locationNodeHospital.transform.position;
        sceneDesc.text = "You narrowly enter the abandoned hospital through the screeching revolving doors of this once safe haven for those in need. A cold darkness engulfs the emergency room you stand in, breezing past your cheeks as to caress you forward deeper into its clasp. The walls tainted with stains and the tile floor corroded beneath your feet. Upon your left you see a director’s guide with barely distinguishable directions to other wings of the hospital, \"Let's hope for some meds this time.\".";
        menuSound.Play();

        SetSceneLibrary(loadLibrary, false);
        SetSceneFactory(loadFactory, false);
        SetSceneHospital(loadHospital, true);
        SetSceneOverworld(loadOverworld, false);
    }

    public void MapPositionChangeLibrary()
    {
        positionTracker.transform.position = locationNodeLibrary.transform.position;
        sceneDesc.text = "You enter through the gaping hole of destruction in the side of the building, standing in the midst of a hallway. A long corridor of busted lockers and vines hanging from the ceiling coat the hallway. Holes in the ceiling light the way in either direction for you to explore, “If only school was as helpful as its downfall has been. Let’s see if we can find some ‘How-To’ books.”.";
        menuSound.Play();

        SetSceneLibrary(loadLibrary, true);
        SetSceneFactory(loadFactory, false);
        SetSceneHospital(loadHospital, false);
        SetSceneOverworld(loadOverworld, false);
    }

    public void MapPositionChangeFactory()
    {
        positionTracker.transform.position = locationNodeFactory.transform.position;
        sceneDesc.text = "You crawl up from underneath the barbed gate of an industrial complex. Once a shining light of progress now left to rot in darkness. You stride cautiously through a graveyard of shrapnel towards the factory at its heart, hoping to find some lost trove of machinized fortune. “I used to hear stories of this place, how it was the lifeblood of this area and its people. They gave so it would give back to them. I miss those days. I miss dad…”.";
        menuSound.Play();

        SetSceneLibrary(loadLibrary, false);
        SetSceneFactory(loadFactory, true);
        SetSceneHospital(loadHospital, false);
        SetSceneOverworld(loadOverworld, false);

    }

    public void MapPositionChangeOverworld()
    {
        positionTracker.transform.position = leaveNode.transform.position;
        sceneDesc.text = "This is 1-topia. A desolate place left in ruin from the upper eschalant of this world. You are a junkrat, a nomad scavenger that relies on what gets left behind to survive, and you alone must search for your means to live. Travel to nearby locations to scavenge and manage your energy so you can overcome this unforgiving place.";
        menuSound.Play();

        SetSceneLibrary(loadLibrary, false);
        SetSceneFactory(loadFactory, false);
        SetSceneHospital(loadHospital, false);
        SetSceneOverworld (loadOverworld, true);
    }

    public void MapPositionChangeFromHospitalOverworld()
    {
        positionTracker.transform.position = leaveNodeHospital.transform.position;
        sceneDesc.text = "This is 1-topia. A desolate place left in ruin from the upper eschalant of this world. You are a junkrat, a nomad scavenger that relies on what gets left behind to survive, and you alone must search for your means to live. Travel to nearby locations to scavenge and manage your energy so you can overcome this unforgiving place.";
        menuSound.Play();

        SetSceneLibrary(loadLibrary, false);
        SetSceneFactory(loadFactory, false);
        SetSceneHospital(loadHospital, false);
        SetSceneOverworld(loadOverworld, true);
    }

    public void MapPositionChangeFromFactoryOverworld()
    {
        positionTracker.transform.position = leaveNodeFactory.transform.position;
        sceneDesc.text = "This is 1-topia. A desolate place left in ruin from the upper eschalant of this world. You are a junkrat, a nomad scavenger that relies on what gets left behind to survive, and you alone must search for your means to live. Travel to nearby locations to scavenge and manage your energy so you can overcome this unforgiving place.";
        menuSound.Play();

        SetSceneLibrary(loadLibrary, false);
        SetSceneFactory(loadFactory, false);
        SetSceneHospital(loadHospital, false);
        SetSceneOverworld(loadOverworld, true);
    }

    public void MapPositionChangeFromLibraryOverworld()
    {
        positionTracker.transform.position = leaveNodeLibrary.transform.position;
        sceneDesc.text = "This is 1-topia. A desolate place left in ruin from the upper eschalant of this world. You are a junkrat, a nomad scavenger that relies on what gets left behind to survive, and you alone must search for your means to live. Travel to nearby locations to scavenge and manage your energy so you can overcome this unforgiving place.";
        menuSound.Play();

        SetSceneLibrary(loadLibrary, false);
        SetSceneFactory(loadFactory, false);
        SetSceneHospital(loadHospital, false);
        SetSceneOverworld(loadOverworld, true);
    }

    public void SetSceneOverworld(GameObject[] loadOverworld, bool loadItems)
    {
        foreach (GameObject nodes in loadOverworld)
        {
            if (nodes != null)
            {
                nodes.SetActive(loadItems);
            }
        }
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
        medItemCounter.sortingOrder = 101;
        largeItemCounter.sortingOrder = 101;
        menuSound.Play();
    }

    public void InventoryScreenClose()
    {
        inventoryScreen.sortingOrder = -100;
        smallItemCounter.sortingOrder = -101;
        medItemCounter.sortingOrder = -101;
        largeItemCounter.sortingOrder = -101;
        menuSound.Play();
    }
}
