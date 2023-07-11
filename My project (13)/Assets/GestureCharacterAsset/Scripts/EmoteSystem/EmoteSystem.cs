using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EmoteSystem : MonoBehaviour
{
    public static EmoteSystem Instance { get; set; }
    public bool isOpened;
    public GameObject player;

    public GameObject buildingMenu;
    //public ThirdPersonOrbitCamBasic cameraController;
 


    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    void Start()
    {

    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            buildingMenu.gameObject.SetActive(true);
            isOpened = true;


            // Below codes for locking-free camera and character movement int Unity Starter Asset, please change it if you use different controller.

            Cursor.lockState = CursorLockMode.None;
            player.GetComponent<StarterAssets.StarterAssetsInputs>().cursorLocked = false;
            player.GetComponent<StarterAssets.StarterAssetsInputs>().cursorInputForLook = false;
            player.GetComponent<StarterAssets.StarterAssetsInputs>().look = new Vector2(0, 0);


        }
        if(Input.GetKeyUp(KeyCode.B))
        {
            buildingMenu.gameObject.SetActive(false);
            isOpened = false;

            // Below codes for locking-free camera and character movement int Unity Starter Asset, please change it if you use different controller.
            player.GetComponent<StarterAssets.StarterAssetsInputs>().cursorLocked = true;
            player.GetComponent<StarterAssets.StarterAssetsInputs>().cursorInputForLook = true;
            Cursor.lockState = CursorLockMode.Locked;
        }


    }

}
