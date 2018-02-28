using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Vuforia;

namespace scripts
{
    public class Vole : MonoBehaviour
    {

        // Use this for initialization
        public float MovementSpeed = 5;

        public GameObject ImageTagetShip;
        public float RotateSpeed = 5;




        private StateManager _sm;
        private TrackableBehaviour _trackableBehaviourMadonna;
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
            _initPosition = ImageTagetShip.transform.position;
            _sm = TrackerManager.Instance.GetStateManager();

        }
        private float time = 5;

        private bool IsGameObjectTracked()
        {
            IEnumerable<TrackableBehaviour> activeTrackables = _sm.GetActiveTrackableBehaviours();

            foreach (TrackableBehaviour trackableBehaviour in activeTrackables)
            {
                if (trackableBehaviour.gameObject.Equals(ImageTagetShip))
                {
                    _trackableBehaviourMadonna = trackableBehaviour;
                    return true;
                }
               
            }
            return false;
        }
        // Update is called once per frame
        void Update()
        {
            IEnumerable<TrackableBehaviour> activeTrackables = _sm.GetActiveTrackableBehaviours();

            foreach (TrackableBehaviour trackableBehaviour in activeTrackables)
            {
                if (trackableBehaviour.gameObject.Equals(ImageTagetShip))
                {
                    _trackableBehaviourMadonna = trackableBehaviour;
                    _find = true;
                    break;
                }
                _find = false;
            }

            if (_find)
            {
                if (_trackableBehaviourMadonna.CurrentStatus == TrackableBehaviour.Status.TRACKED)
                {
                    transform.Translate(Vector3.forward * MovementSpeed * Time.deltaTime);
                    transform.Rotate(Vector3.forward * RotateSpeed * Time.deltaTime);
                }

                if (_needReset)
                {
                    transform.position = ImageTagetShip.transform.position;
                    _needReset = false;
                }

            }

        }
    }
}
