using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemCollector : MonoBehaviour
{

    int coins = 0;
    int coinsMax;

    [SerializeField] TextMeshProUGUI coinsText;

    void Start() {
        coinsMax = GameObject.FindGameObjectsWithTag("Coin").Length;
        coinsText.text = "Coins: " + coins +"/"+ coinsMax;
    }

    private void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            coins++;
            coinsText.text = "Coins: " + coins +"/" + coinsMax;
        }        
    }
}
