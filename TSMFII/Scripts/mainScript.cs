using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mainScript : MonoBehaviour
{
    public bool mainDropdownisOpening;
    public bool mainDropdownisClosing;
    public bool mainDropdownisOpened;
    public bool mainDropdownisClosed = true;
    public GameObject mainMenuDropdownOrig;
    public GameObject mainMenuDropdownDropped;
    public GameObject mainMenuDropdownArrow;

    public GameObject activePanel;
    public GameObject startScreen;
    public GameObject mainMenu;
    public GameObject description;

    public GameObject mainMenuDropdown;
    public GameObject modelConfirmation;
    public GameObject mountedComponents;
    public GameObject solderabilityInspection;
    public GameObject evidenceOfNoGaps;
    public GameObject correctStaySensor;
    public GameObject ngUnits;
    public GameObject solderBallsCriteria;

    public GameObject safetyConcern;

    public Button burger;
    public Button getStarted;

    public GameObject sidePanel;
    public bool movingSidePanel;
    public bool movingSidePanelBack;
    public bool movedSidePanel;
    public bool movedSidePanelBack = true;
    public GameObject sidePanelOrigPos;
    public GameObject sidePanelActivePos;


    public bool sideDropdownisOpening;
    public bool sideDropdownisClosing;
    public bool sideDropdownisOpened;
    public bool sideDropdownisClosed = true;
    public GameObject sideDropdown;
    public GameObject sideDropdownOrig;
    public GameObject sideDropdownDropped;
    public GameObject SF;
    public GameObject SC;
    public Transform sideDropdownArrow;
    public GameObject exitSidePanel;

    public float dropdownAnimationSpeed = 3000f;
    public float arrowdropdownAnimationSpeed = 310f;


    void Start()
    {
        activePanel = startScreen;
        sidePanel.transform.position = sidePanelOrigPos.transform.position;
    }


    void Update()
    {
        sidePanelAnimation();
        mainMenuDropdownAnimation();
        SideDropdownAnimation();
    }
    

    public void sidePanelAnimation(){
        if (movingSidePanel)
        {
            //print("side panel opening");
            sidePanel.transform.Translate(dropdownAnimationSpeed * Time.deltaTime, 0, 0);

            if (sidePanel.transform.localPosition.x >= sidePanelActivePos.transform.localPosition.x)
            {
                //print("side panel OPENED NOW");
                movingSidePanel = false;
                movedSidePanel = true;
                sidePanel.transform.position = sidePanelActivePos.transform.position;
            }
        }

        else if (movingSidePanelBack)
        {
            //print("side panel closing");
            sidePanel.transform.Translate(-dropdownAnimationSpeed * Time.deltaTime, 0, 0);

            if (sidePanel.transform.localPosition.x <= sidePanelOrigPos.transform.localPosition.x)
            {
                //print("side panel CLOSED NOW");
                movingSidePanelBack = false;
                movedSidePanelBack = true;
                sidePanel.transform.position = sidePanelOrigPos.transform.position;
            }
        }
    }

    public void movePanel(){
        movingSidePanel = true;
        exitSidePanel.SetActive(true);
    }

    public void movePanelBack(){
        movingSidePanelBack = true;
        exitSidePanel.SetActive(false);
    }

    //main code for switching screens
    public void SetActivePanel(GameObject newPanel)
    {
        activePanel.SetActive(false);
        newPanel.SetActive(true);
        activePanel = newPanel;
    }
    
    public void mainMenuDropdownAnimation()
    {
        if (mainDropdownisOpening)
        {
            //print("main menu drop down opening");
            mainMenuDropdown.transform.Translate(0, -dropdownAnimationSpeed * Time.deltaTime, 0);

            mainMenuDropdownArrow.transform.Rotate(0 , 0, -arrowdropdownAnimationSpeed * Time.deltaTime);

            if (mainMenuDropdown.transform.localPosition.y <= mainMenuDropdownDropped.transform.localPosition.y)
            {
                //print("main menu drop down OPENED NOW");
                mainDropdownisOpening = false;
                mainDropdownisOpened = true;
                mainMenuDropdown.transform.position = mainMenuDropdownDropped.transform.position;
                mainMenuDropdownArrow.transform.rotation = Quaternion.Euler(0, 0, 0);
            }
        }

        else if (mainDropdownisClosing)
        {
            //print("main menu drop down closing");
            mainMenuDropdown.transform.Translate(0, dropdownAnimationSpeed * Time.deltaTime, 0);

            mainMenuDropdownArrow.transform.Rotate(0, 0, arrowdropdownAnimationSpeed * Time.deltaTime);

            if (mainMenuDropdown.transform.localPosition.y >= mainMenuDropdownOrig.transform.localPosition.y)
            {
                //print("main menu drop down CLOSED NOW");
                mainDropdownisClosing = false;
                mainDropdownisClosed = true;
                mainMenuDropdown.transform.position = mainMenuDropdownOrig.transform.position;
                mainMenuDropdownArrow.transform.rotation = Quaternion.Euler(0, 0, 90);
            }
        }
    }

    public void maindropDownClose()
    {
        mainDropdownisClosing = true;
    }

    public void mainDropdownOpenClose()
    {
        if (mainDropdownisClosed)
        {
            mainDropdownisClosed = false;
            mainDropdownisOpening = true;
        }
        else if (mainDropdownisOpened) 
        {
            mainDropdownisOpened = false;
            mainDropdownisClosing = true;
        }
    }

    public void SideDropdownAnimation()
    {
        if (sideDropdownisOpening)
        {
            //print("sidebar drop down opening");
            sideDropdown.transform.Translate(0, -dropdownAnimationSpeed * Time.deltaTime, 0);
            SF.transform.transform.Translate(0, -dropdownAnimationSpeed * Time.deltaTime, 0);
            SC.transform.transform.Translate(0, -dropdownAnimationSpeed * Time.deltaTime, 0);

            sideDropdownArrow.transform.Rotate(0, 0, -arrowdropdownAnimationSpeed * Time.deltaTime);

            if (sideDropdown.transform.localPosition.y <= sideDropdownDropped.transform.localPosition.y)
            {
                //print("sidebar drop down OPENED NOW");
                sideDropdownisOpening = false;
                sideDropdownisOpened = true;
                sideDropdown.transform.position = sideDropdownDropped.transform.position;
                sideDropdownArrow.transform.rotation = Quaternion.Euler(0, 0, 0);
            }
        }

        else if (sideDropdownisClosing)
        {
            //print("sidebar drop down closing");
            sideDropdown.transform.Translate(0, dropdownAnimationSpeed * Time.deltaTime, 0);
            SF.transform.transform.Translate(0, dropdownAnimationSpeed * Time.deltaTime, 0);
            SC.transform.transform.Translate(0, dropdownAnimationSpeed * Time.deltaTime, 0);

            sideDropdownArrow.transform.Rotate(0, 0, arrowdropdownAnimationSpeed * Time.deltaTime);

            if (sideDropdown.transform.localPosition.y >= sideDropdownOrig.transform.localPosition.y)
            {
                //print("sidebar drop down CLOSED NOW");
                sideDropdownisClosing = false;
                sideDropdownisClosed = true;
                sideDropdown.transform.position = sideDropdownOrig.transform.position;
                sideDropdownArrow.transform.rotation = Quaternion.Euler(0, 0, 90);
            }
        }
    }

    public void SidedropDownClose()
    {
        sideDropdownisClosing = true;
        sideDropdownisOpening = false;
    }

    public void SideDropdownOpenClose()
    {
        if (sideDropdownisClosed)
        {
            sideDropdownisClosed = false;
            sideDropdownisOpening = true;
        }
        else if (sideDropdownisOpened)
        {
            sideDropdownisOpened = false;
            sideDropdownisClosing = true;
        }

    }

    public void SetBurgerActive()
    {
        burger.gameObject.SetActive(!burger.gameObject.activeInHierarchy);
    }
}