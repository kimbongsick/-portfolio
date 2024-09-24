using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSpawner : MonoBehaviour
{
    public GameObject CardPrefab;
    //private Transform canvas;

    /*void Start()
    {
        //canvas = FindObjectOfType<Canvas>().transform;
        Instantiate(CardPrefab, transform.position, Quaternion.identity, transform.parent);     // Instantiate를 부모 오브젝트에 할당
    }*/

    void Update()
    {
        
    }

    public void Spwan()
    {
        Debug.Log("호출");
        Instantiate(CardPrefab, transform.position, Quaternion.identity, transform.parent);     // Instantiate를 부모 오브젝트에 할당
        //GameObject Card = Instantiate(CardPrefab, transform.position, transform.rotation);
    }
}
