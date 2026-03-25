using UnityEngine;
using UnityEngine.SceneManagement;

namespace Divij 
{
    public class SceneSwapper : MonoBehaviour
    {
    
        [SerializeField] public string sceneName;
    
        public void LoadByName()
        {
            SceneManager.LoadScene(sceneName);
        }
    }

}

/*


*/