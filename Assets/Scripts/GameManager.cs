using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    GameObject sceneCanvas;
    Image uiImage;

    public string heldItem = "";

    // Start is called before the first frame update
    void Start()
    {
        sceneCanvas = GameObject.Find("Canvas");
        uiImage = sceneCanvas.GetComponentInChildren<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadSceneFromDoor(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public bool PickupItem(Container containerInfo)
    {
        if (heldItem == "")
        {
            heldItem = containerInfo.itemName;
            uiImage.sprite = containerInfo.itemSprite;
            uiImage.enabled = true;
            return true;
        }
        else
        {
            return false;
        }
    }
}
