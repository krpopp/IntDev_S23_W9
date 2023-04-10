using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollide : MonoBehaviour
{

    GameManager myManager;

    // Start is called before the first frame update
    void Start()
    {
        myManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Door")
        {
            myManager.LoadSceneFromDoor(collision.GetComponent<Portal>().sceneToLoad);
        }
        if (collision.tag == "Chest")
        {
            Container hitContainer = collision.GetComponent<Container>();
            if (myManager.PickupItem(hitContainer))
            {
                Destroy(collision.gameObject);
            }
        }
    }
}
