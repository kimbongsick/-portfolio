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
        Instantiate(CardPrefab, transform.position, Quaternion.identity, transform.parent);     // Instantiate�� �θ� ������Ʈ�� �Ҵ�
    }*/

    void Update()
    {
        
    }

    public void Spwan()
    {
        Debug.Log("ȣ��");
        Instantiate(CardPrefab, transform.position, Quaternion.identity, transform.parent);     // Instantiate�� �θ� ������Ʈ�� �Ҵ�
        //GameObject Card = Instantiate(CardPrefab, transform.position, transform.rotation);
    }
}
