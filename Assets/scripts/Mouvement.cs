using UnityEngine;
using UnityEngine.Video;

public class Mouvement : MonoBehaviour
{
    public bool _upClicked;
    private bool _downClicked;
    private bool _leftClicked;
    private bool _rightClicked;
    private VideoPlayer _videoPlayer;

   private void video()
    {
        _videoPlayer = GetComponent<VideoPlayer>();
        _videoPlayer.Pause();

        
    }



    //private StateManager _sm;
    //private IEnumerable<TrackableBehaviour> _activeTrackables;
    //private TrackableBehaviour _trackableBehaviourMadonna;
    
    //float MovementSpeed = 10;
    //private float RotateSpeed = 100;

    //public void UpOnClick()
    //{
    //    _upClicked = true;
    //    Debug.Log(" up click ");
    //    _upClicked = !_upClicked;
    //}

    //public void DownOnClick()
    //{
    //    _downClicked = true;
    //    Debug.Log(" down click ");
    //    _downClicked = !_downClicked;
    //}


    //public void LeftOnClick()
    //{
    //    _leftClicked = true;
    //    Debug.Log(" left click ");
    //    _leftClicked = !_leftClicked;
    //}

    //public void RightOnClick()
    //{
    //    _rightClicked = true;
    //    Debug.Log(" right click ");
    //    _rightClicked = !_rightClicked;
    //}

    //void Start()
    //{
        
    //    _upClicked = false;
    //    _downClicked = false;
    //    _leftClicked = false;
    //    _rightClicked = false;

    //    _sm = TrackerManager.Instance.GetStateManager();
    //}

    //private bool find;

    ////Update is called once per frame
    //void Update()
    //{
    //    IEnumerable<TrackableBehaviour> activeTrackables = _sm.GetActiveTrackableBehaviours();
    //    foreach (TrackableBehaviour trackableBehaviour in activeTrackables)
    //    {
    //        if (trackableBehaviour.gameObject == gameObject)
    //        {
    //            _trackableBehaviourMadonna = trackableBehaviour;
    //            find = true;
    //            return;
    //        }
    //        find = false;
    //    }
    //    if (find)
    //    {
    //        if (_trackableBehaviourMadonna.CurrentStatus == TrackableBehaviour.Status.TRACKED)
    //        {
    //            gameObject.transform.Translate(Vector3.forward * MovementSpeed * Time.deltaTime);
    //        }

    //        if (_upClicked)
    //        {
    //            gameObject.transform.Rotate(Vector3.forward * RotateSpeed * Time.deltaTime);
    //        }

    //        if (_downClicked)
    //        {
    //            gameObject.transform.Rotate(Vector3.up * RotateSpeed * Time.deltaTime);
    //        }

    //        if (_rightClicked)
    //        {
    //            gameObject.transform.Rotate(Vector3.right * RotateSpeed * Time.deltaTime);
    //        }

    //        if (_leftClicked)
    //        {
    //            gameObject.transform.Rotate(Vector3.left * RotateSpeed * Time.deltaTime);
    //        }
    //    }




        //        transform.rotation *= Quaternion.AngleAxis(Input.getAxis("Horizontal") * this.speed * time.deltaTime, Vector3.up);
        //        if (Input.touches.Count() > 0)
        //        {
        //            var touch = Input.touches[0];
        //            if (touch.phase == TouchPhase.Began)
        //            {
        //                var touchposition = Camera.main.ScreenToWorldPoint(touch.position);
        //                if (_upClicked.transform.position == touchposition)
        //                    UpOnPush();
        //
        //            }
        //            if (touch.phase == TouchPhase.Ended)
        //            {
        //
        //            }
        //        }
    //}
}