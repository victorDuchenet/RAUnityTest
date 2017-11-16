using UnityEngine;

namespace Assets
{
    public class BtnClickReset : MonoBehaviour
    {
        private GameObject _ship;
        private Vector3 _initPositionShip;
        private Vole ScriptVole;

        void Start()
        {
            _initPositionShip = new Vector3(0, 0, 0);
            _ship = GameObject.FindWithTag("RedShip");
            ScriptVole = (Vole)_ship.GetComponent(typeof(Vole));

        }

        public void ResetOnClick()
        {
            Debug.Log("click done");
            ScriptVole.Reset();

        }
    }
}


