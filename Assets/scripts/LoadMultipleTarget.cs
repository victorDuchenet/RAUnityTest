using UnityEngine;
using UnityEngine.SceneManagement;

namespace scripts
{
    public class LoadMultipleTarget : MonoBehaviour {

        // Use this for initialization
        void Start () {
            
        }
	
        // Update is called once per frame
        void Update () {
		
        }

        public void LoadMultipleTargetScene()
        {
           
            SceneManager.LoadScene("mutlipleTarget");
        }
    }
}
