using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public bool hasKey;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("hasKey: " + hasKey);
    }

    public void LoadSceneFromDoor(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public bool PickupItem(Container containerInfo)
    {
        if (!hasKey)
        {
            hasKey = true;
            return true;
        }
        else
        {
            return false;
        }
    }
}
