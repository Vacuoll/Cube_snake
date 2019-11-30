using UnityEngine;
using UnityEngine.EventSystems;

namespace Buttons
{
    public class Buttons : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
    {

        public void OnPointerDown(PointerEventData evenData)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 5f, transform.position.z);
        }

        public void OnPointerUp(PointerEventData evenData)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - 5f, transform.position.z);
        }
    }
}
