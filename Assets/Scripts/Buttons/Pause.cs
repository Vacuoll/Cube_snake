using UnityEngine;
using UnityEngine.EventSystems;

namespace Buttons
{
    public class Pause : MonoBehaviour, IPointerClickHandler
    {
        public GameObject PanelPause;
        public bool paused = false;
        private CubeMovement IsPause;
        private Continue IsContinue;
        public GameObject Cont;
     
  
        void Start()
        {
            IsPause = GameObject.FindGameObjectWithTag("CubeMain").GetComponent<CubeMovement>();
            IsContinue = Cont.GetComponent<Continue>();

        }
        void Update()
        {
            if (IsPause.pause == true)
                paused = true;
            else
            if (IsContinue.continuation == true)
            {
                paused = false;
                IsContinue.continuation = false;
            }

            if (!paused)
                Time.timeScale = 1;
            else
            {
                Time.timeScale = 0;
                gameObject.SetActive(false);
            }
        }
        public void OnPointerClick(PointerEventData eventData)
        {
            PanelPause.SetActive(true);
            paused = true;

            Time.timeScale = 0;
        }
    }
}
