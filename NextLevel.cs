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

    //Sahne Geçişlerinde kullandığım Kod
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(scene.buildIndex+1);
        }
    }
    //Oyun sonu ve Oyunu ilk başlattığımda kullandığım kodum
    public void NextLvl()
    {
        //sahnede verdiğim index değerli sahneyi yükle
        SceneManager.LoadScene(sceneIndex);
        //Oyunu ilk başlattığımı var sayarak can sayısını 3 yapıyorum
        PlayerInfo.oyuncuCanSeviyesi = 3;
    }
}
