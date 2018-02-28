using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Vuforia;

namespace scripts
{
    public class Vole : MonoBehaviour, ITrackableEventHandler
    {

        // Use this for initialization
        public float MovementSpeed = 5;

        public GameObject ImageTagetShip;
        public float RotateSpeed = 5;

        private TrackableBehaviour _mTrackableBehaviour;
        private bool _find;

        private Vector3 _initPosition;
        private bool _needReset = false;

        public void Reset()
        {
            transform.Translate(_initPosition);
            _needReset = true;
        }

        public void LeaveApp()
        {
            Application.Quit();
        }

        void Start()
        {
            _mTrackableBehaviour = ImageTagetShip.GetComponent<TrackableBehaviour>();
            if (_mTrackableBehaviour)
            {
                _mTrackableBehaviour.RegisterTrackableEventHandler(this);
            }

            _initPosition = ImageTagetShip.transform.position;
        }


        // Update is called once per frame
        void Update()
        {
            if (_find)
            {
                transform.Translate(Vector3.forward * MovementSpeed * Time.deltaTime);
                transform.Rotate(Vector3.forward * RotateSpeed * Time.deltaTime);


                if (_needReset)
                {
                    transform.position = ImageTagetShip.transform.position;
                    _needReset = false;
                }

            }

        }

        public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
        {
            if (newStatus == TrackableBehaviour.Status.TRACKED ||
                newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
            {
                _find = true;
                Debug.Log("_find = true");
            }
            else
            {
                _find = false;
                Debug.Log("_find = false");

            }
        }
    }
}
