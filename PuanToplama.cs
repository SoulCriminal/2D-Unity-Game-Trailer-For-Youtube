using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PuanToplama : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    //[SerializeField] int Score = 0;
    AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        scoreText.text = "Puan: " + PlayerInfo.puan.ToString();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Elmas"))
        {
            Destroy(collision.gameObject);
            //Score++;
            PlayerInfo.puan++;
            scoreText.text = "Puan: "+PlayerInfo.puan.ToString();
            audioSource.Play();
        }
    }
}
