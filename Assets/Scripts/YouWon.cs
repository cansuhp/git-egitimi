using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YouWon : MonoBehaviour
{

    public Text text;

    void Start()
    {
        text.color = new Color(0, 0, 0, 0);
    }

    void OnTriggerEnter(Collider other)
    {
        text.color = new Color(0, 0, 0, 1);

        if (other.CompareTag("Player"))
        {
            text.text = "You Won!";
            Debug.Log("Player entered trigger area");
        }
    }
}
