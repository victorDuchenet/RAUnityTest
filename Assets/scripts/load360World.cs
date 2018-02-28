using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

namespace scripts
{
    public class load360World : MonoBehaviour
    {
        private TrackableBehaviour _trackableBehaviour;
        private StateManager sm;

        // Use this for initialization
        void Start()
        {
            sm = TrackerManager.Instance.GetStateManager();
        }


        // Update is called once per frame
        void Update()
        {
            IEnumerable<TrackableBehaviour> activeTrackables = sm.GetActiveTrackableBehaviours();
            foreach (TrackableBehaviour trackableBehaviour in activeTrackables)
            {
                if (trackableBehaviour.gameObject == gameObject)
                {
                    SceneManager.LoadScene("360World");
                }
            }
        }
    }
}