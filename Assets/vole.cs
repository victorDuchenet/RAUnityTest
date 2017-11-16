
using UnityEngine;

public class Vole : MonoBehaviour
{

    // Use this for initialization
    public float MovementSpeed = 0;
    public float RotateSpeed = 0;
    Vector3 _initPosition;
    private bool _needReset = false;
    
    public void Reset()
    {
        transform.Translate(_initPosition);
        _needReset = true;
        Debug.Log("reset reach");
        Debug.Log(_initPosition);

    }

    void Start()
    {
        _initPosition = gameObject.transform.position;
        Debug.Log(_initPosition);
    }

    // Update is called once per frame
    void Update()
    {
        if (_needReset)
        {
            transform.position = _initPosition;
            _needReset = false;
        }
        transform.Translate(Vector3.forward * MovementSpeed * Time.deltaTime);

        transform.Rotate(Vector3.forward * RotateSpeed * Time.deltaTime);

        
    }
}
