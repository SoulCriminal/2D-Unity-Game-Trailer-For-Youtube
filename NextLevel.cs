using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NextLevel : MonoBehaviour
{
    Scene scene;
    public int sceneIndex;

    private void Awake()
    {
        scene = SceneManager.GetActiveScene();
    }

    //Sahne Ge�i�lerinde kulland���m Kod
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(scene.buildIndex+1);
        }
    }
    //Oyun sonu ve Oyunu ilk ba�latt���mda kulland���m kodum
    public void NextLvl()
    {
        //sahnede verdi�im index de�erli sahneyi y�kle
        SceneManager.LoadScene(sceneIndex);
        //Oyunu ilk ba�latt���m� var sayarak can say�s�n� 3 yap�yorum
        PlayerInfo.oyuncuCanSeviyesi = 3;
    }
}
