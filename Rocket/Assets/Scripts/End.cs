using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class End : MonoBehaviour
{
    private string end = "You Won!";

    public TextMeshProUGUI textCoins;

    private void OnTriggerEnter(Collider other)
    {
        textCoins.text = end.ToString();
    }
}
