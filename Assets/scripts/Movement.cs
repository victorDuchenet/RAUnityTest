using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class Movement : MonoBehaviour
{

    public bool _upClicked;
    private bool _downClicked;
    private bool _leftClicked;
    private bool _rightClicked;

    float MovementSpeed = 10;
    private float RotateSpeed = 100;


    public void UpOnClick()
    {
        _upClicked = true;
        Debug.Log(" up click ");
        _upClicked = !_upClicked;

    }

    public void DownOnClick()
    {
        _downClicked = true;
        Debug.Log(" down click ");
        _downClicked = !_downClicked;
    }


    public void LeftOnClick()
    {
        _leftClicked = true;
        Debug.Log(" left click ");
        _leftClicked = !_leftClicked;
    }

    public void RightOnClick()
    {
        _rightClicked = true;
        Debug.Log(" right click ");
        _rightClicked = !_rightClicked;
    }
    void Start()
    {
        _upClicked = false;
        _downClicked = false;
        _leftClicked = false;
        _rightClicked = false;
        Debug.Log("Start called !!!");
    }

    // Update is called once per frame
    void Update()
    {
        StateManager sm = TrackerManager.Instance.GetStateManager();

        // Query the StateManager to retrieve the list of
        // currently 'active' trackables 
        //(i.e. the ones currently being tracked by Vuforia)
        IEnumerable<TrackableBehaviour> activeTrackables = sm.GetActiveTrackableBehaviours();

        foreach (TrackableBehaviour trackableBehaviour in activeTrackables)
        {
            trackableBehaviour.transform.Translate(Vector3.forward * MovementSpeed * Time.deltaTime);
        }


        if (_upClicked)
        {
            foreach (TrackableBehaviour trackableBehaviour in activeTrackables)
            {
                Debug.Log("trackable name : " + trackableBehaviour.TrackableName);
                trackableBehaviour.transform.Rotate(Vector3.forward * RotateSpeed * Time.deltaTime);
            }
        }

        if (_downClicked)
        {
            foreach (TrackableBehaviour trackableBehaviour in activeTrackables)
            {
                Debug.Log("trackable name : " + trackableBehaviour.TrackableName);
                trackableBehaviour.transform.Rotate(Vector3.up * RotateSpeed * Time.deltaTime);
            }
          
        }

        if (_rightClicked)
        {
            foreach (TrackableBehaviour trackableBehaviour in activeTrackables)
            {
                Debug.Log("trackable name : " + trackableBehaviour.TrackableName);
                trackableBehaviour.transform.Rotate(Vector3.right * RotateSpeed * Time.deltaTime);
            }
        }

        if (_leftClicked)
        {
            foreach (TrackableBehaviour trackableBehaviour in activeTrackables)
            {
                Debug.Log("trackable name : " + trackableBehaviour.TrackableName);
                trackableBehaviour.transform.Rotate(Vector3.left * RotateSpeed * Time.deltaTime);
            }
        }


        // transform.rotation *= Quaternion.AngleAxis(Input.getAxis("Horizontal") * this.speed * time.deltaTime, Vector3.up);
        //if (Input.touches.Count() > 0)
        //{
        //    var touch = Input.touches[0];
        //    if (touch.phase == TouchPhase.Began)
        //    {
        //        var touchposition = Camera.main.ScreenToWorldPoint(touch.position);
        //        if(_upClicked.transform.position == touchposition)
        //            UpOnPush();

        //    }
        //    if (touch.phase == TouchPhase.Ended)
        //    {

        //    }
        //}
    }
}
