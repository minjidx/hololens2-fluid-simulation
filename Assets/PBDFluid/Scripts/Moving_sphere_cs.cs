using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_sphere_cs : MonoBehaviour
{
    public float _line_width = 0.005f;
    public LineRenderer _Line;

    public GameObject _Sphere_Start_;
    public GameObject _Sphere_End_;

    public Vector3 _start_pos;
    public Vector3 _end_pos;

    public Vector3 _dirVector = Vector3.zero;

    

    void Start()
    {
        _Line = gameObject.GetComponent<LineRenderer>();
        _Line.startWidth = _line_width;
        _Line.endWidth = _line_width;

        _start_pos = new Vector3(-3.43f,3.47f,-8.64f);
        _end_pos = _Sphere_End_.transform.position;

    }


    void Update()
    {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _Sphere_End_.transform.Translate(-0.1f, 0.0f, 0.0f);
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            _Sphere_End_.transform.Translate(0.1f, 0.0f, 0.0f);
        }

        else if (Input.GetKey(KeyCode.UpArrow))
        {
            _Sphere_End_.transform.Translate(0.0f, 0.0f, 0.1f);
        }

        else if (Input.GetKey(KeyCode.DownArrow))
        {
            _Sphere_End_.transform.Translate(0.0f, 0.0f, -0.1f);
        }

        else if (Input.GetKey(KeyCode.PageUp))
        {
            _Sphere_End_.transform.Translate(0.0f, 0.1f, 0.0f);
        }

        else if (Input.GetKey(KeyCode.PageDown))
        {
            _Sphere_End_.transform.Translate(0.0f, -0.1f, 0.0f);
        }

        _end_pos = _Sphere_End_.transform.position;

        _Line.SetPosition(0, _start_pos);
        _Line.SetPosition(1, _end_pos);

        _dirVector = _end_pos - _start_pos;

       // Debug.Log(_dirVector);
    }
}
