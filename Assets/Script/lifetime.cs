using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lifetime : MonoBehaviour
{
    public float duration = 2f;

    private float _timer;

    // Start is called before the first frame update
    void Start()
    {
        _timer = duration;
    }

    // Update is called once per frame
    void Update()
    {
      if (_timer > 0)
        {
            _timer -= Time.deltaTime;
            return;
        }  

      Destroy(gameObject);
    }
}
