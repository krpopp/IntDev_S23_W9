using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save_Pos_TatiAaron_Ben : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("playerX"))
        {
            //Player confirming that it has a recorded a new position, and setting its current position to the new position

            float x = PlayerPrefs.GetFloat("playerX");
            float y = PlayerPrefs.GetFloat("playerY");
            transform.position = new Vector3(x, y, 0); 
        }
    }

    // Update is called once per frame
    void Update()
    {

        //when we press space bar, x and y position of player gets recorded 
      if (Input.GetKeyDown(KeyCode.Space))
        {
            //playerX is our Key, for saving x position
            PlayerPrefs.SetFloat("playerX", transform.position.x);

            //playerY is our Key, for saving y position
            PlayerPrefs.SetFloat("playerY", transform.position.y);

            Debug.Log("saved position!");
        }

    }
}



