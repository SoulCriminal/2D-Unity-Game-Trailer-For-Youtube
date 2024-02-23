using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Engel : MonoBehaviour
{
    public int index;
    private Scene _scene;
    [SerializeField] TextMeshProUGUI oyuncuCan;

    private void Awake()
    {
        _scene = SceneManager.GetActiveScene();
        oyuncuCan.text = "Can Sayýsý: "+ PlayerInfo.oyuncuCanSeviyesi.ToString();
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            
            PlayerInfo.oyuncuCanSeviyesi--;
            SceneManager.LoadScene(_scene.buildIndex);
        }
        if(PlayerInfo.oyuncuCanSeviyesi <= 0)
        {
            SceneManager.LoadScene(index);
        }
    }
}
