using UnityEngine;
using UnityEngine.SceneManagement;

//this script detects a collision between the player character and any gameobject tagged as "enemy"
//when the collision is detected, it restarts the game scene
public class DeathRestartScene : MonoBehaviour
{
    private string reloadingscene;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("LoadScene");
        reloadingscene = SceneManager.GetActiveScene().name;
    }

    //when hitting an "enemy" object, restart the game scene
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print (collision.gameObject.tag);
        if (collision.gameObject.tag == "enemy")
        {
            SceneManager.LoadScene(reloadingscene);
        }
    }
}
