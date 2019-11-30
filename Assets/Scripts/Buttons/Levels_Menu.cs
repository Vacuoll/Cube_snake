using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Buttons
{
    public class Levels_Menu : MonoBehaviour
    {
        public Button Level2B;
        int levelComplete;
   
        void Start()
        {
            levelComplete = PlayerPrefs.GetInt("LevelComplete");
            PlayerPrefs.Save();

            Level2B.interactable = false;
        

            switch (levelComplete)
            {
                case 2:
                    Level2B.interactable = true;
                    break;
            }
        }

        public void LoadTo(int level)
        {
            SceneManager.LoadScene(level);
        }
        public void Reset()
        {
            Level2B.interactable = false;
            PlayerPrefs.DeleteAll();
            PlayerPrefs.Save();
        }

    }
}
