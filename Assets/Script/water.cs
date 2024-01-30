using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water : MonoBehaviour
{
    public int ScoreAmount = 10;
    private Collider2D _collider2D;

    public GameObject soundprefab;
    public GameObject particalesprefab;

    private scoremanager _scoremanager;

    // Start is called before the first frame update
    void Start()
    {
        _collider2D = GetComponent<Collider2D>();

        _scoremanager = FindObjectOfType<scoremanager>();
    }

    void OnMouseOver()
    {
        Debug.Log("water collected, hydrated " + ScoreAmount);

        if (_scoremanager != null)
        {
            _scoremanager.coinscollected(ScoreAmount);
        }

        if (soundprefab != null)
        {
            GameObject.Instantiate(soundprefab, transform.position, transform.rotation);
        }

        if (particalesprefab != null)
        {
            GameObject.Instantiate(particalesprefab, transform.position, transform.rotation);
        }

        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
