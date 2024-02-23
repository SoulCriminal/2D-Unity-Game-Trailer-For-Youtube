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

    //Sahne Geçiþlerinde kullandýðým Kod
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(scene.buildIndex+1);
        }
    }
    //Oyun sonu ve Oyunu ilk baþlattýðýmda kullandýðým kodum
    public void NextLvl()
    {
        //sahnede verdiðim index deðerli sahneyi yükle
        SceneManager.LoadScene(sceneIndex);
        //Oyunu ilk baþlattýðýmý var sayarak can sayýsýný 3 yapýyorum
        PlayerInfo.oyuncuCanSeviyesi = 3;
    }
}
