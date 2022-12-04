using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBallLife : MonoBehaviour
{

    bool dead = false;

    void Update() 
    {
        if (transform.position.y < -1.5f && dead == false) //Safe Check for leaving board
        {
            Die();
        }    
    }
    private void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.CompareTag("Enemy")) 
        {
            GetComponent<MeshRenderer>().enabled = false; //Make Player invisible when dead
            GetComponent<Rigidbody>().isKinematic = true; //Disable Player psychics
            GetComponent<PlayerBallMovement>().enabled = false; //Disable Player movement script
            Die();
        }
    }

    void Die()
    {
        dead = true;
        Invoke(nameof(ReloadLevel),1.3f); //Reload Scene after 1.3s
    }

    void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
