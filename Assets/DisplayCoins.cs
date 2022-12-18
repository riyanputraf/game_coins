using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayCoins : MonoBehaviour
{

    public static int numberOfDisplayCoins;
    public TextMeshProUGUI numberOfDisplayCoinsText;
    // Start is called before the first frame update
    void Start()
    {
        numberOfDisplayCoins = 0;
    }

    // Update is called once per frame
    void Update()
    {
        numberOfDisplayCoinsText.text = "Coins: " +  numberOfDisplayCoins;
    }
}

