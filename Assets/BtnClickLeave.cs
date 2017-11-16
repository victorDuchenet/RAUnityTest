using UnityEngine;

namespace Assets
{
    public class BtnClickLeave : MonoBehaviour {

        public void LeaveOnCLick()
        {
            Debug.Log("Leave click");
            Application.Quit();
        }
    }
}
