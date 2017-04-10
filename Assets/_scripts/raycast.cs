using UnityEngine;
using System.Collections;
namespace raycastNS  
{

    public class raycast : MonoBehaviour
    {
        public RaycastHit hit;
        Ray ray;
        public float range;
        public GameObject emptyGM;
        [SpaceAttribute]
        [HeaderAttribute("do not put anything in those the thing under this!!")]
        public GameObject rayCastGameObject;


        void Start()
        {
            ray = Camera.main.ViewportPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 10));
            rayCastGameObject = emptyGM;
        }

        void Update()
        {
            int x = Screen.width / 2;
            int y = Screen.height / 2;
            ray = Camera.main.ScreenPointToRay(new Vector3(x, y));
            if (Physics.Raycast(ray, out hit, range))
            {
                rayCastGameObject = hit.transform.gameObject;
            }
            else
            {
                rayCastGameObject = emptyGM;
            }



        }
    }

}