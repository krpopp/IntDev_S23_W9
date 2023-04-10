using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPref_AJ : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // check to see if you have a saved position and then go if you do 
        if (PlayerPrefs.HasKey("playerX"))
        {
            // get the save position 
            float x = PlayerPrefs.GetFloat("playerX");
            float y = PlayerPrefs.GetFloat("playerY");
            // set player as position 
            transform.position = new Vector3(x, y, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // playerprefs store strings, floats, & int
            // you can use it for music preferences, location of the player, etc...
            PlayerPrefs.SetFloat("playerX", transform.position.x); //1st argument is the key
            PlayerPrefs.SetFloat("playerY", transform.position.y); //2nd argument is player position 
            Debug.Log("saved position");
        }
    }
}
