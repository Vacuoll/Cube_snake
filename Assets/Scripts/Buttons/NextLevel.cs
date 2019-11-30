using UnityEngine;
using UnityEngine.EventSystems;

namespace Buttons
{
    public class NextLevel : MonoBehaviour, IPointerClickHandler
    {
        public void OnPointerClick(PointerEventData eventData)
        {
            LevelController.instance.IsEndGame();
        }
    }
}
