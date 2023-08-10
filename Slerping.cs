using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slerping : MonoBehaviour
{
    private Vector3 _startPostion;
    private Vector3 _endPostion = new Vector3(3, -3, 0);
    private float _deisredDuratoin = .4f;
    private float _timeEslped;

    private bool _istrue = true;

    // Start is called before the first frame update
    void Start()
    {
        _startPostion = transform.position;
       
    }
    private void Update()
    {
        _timeEslped += Time.deltaTime;
        float _completedLerp = _timeEslped / _deisredDuratoin;

        transform.position = Vector3.Slerp(_startPostion, _endPostion, _completedLerp);
    }

}
