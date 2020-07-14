using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

//this script detects a collision between the player character and any gameobject tagged as "wincon"
//when the collision is detected, it pops up a Canvas object that tells you you've won
public class WinConCollision : MonoBehaviour
{
    public Canvas myDialogueBox;
    private Text myDialogue;
    public string wintext;


    // Start is called before the first frame update
    void Start()
    {
        myDialogue = myDialogueBox.GetComponentInChildren<Text>();
        myDialogueBox.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print (collision.gameObject.tag);
        if (collision.gameObject.tag == "wincon")
        {
            myDialogueBox.gameObject.SetActive(true);
            myDialogue.text = wintext;
        }
    }
}
