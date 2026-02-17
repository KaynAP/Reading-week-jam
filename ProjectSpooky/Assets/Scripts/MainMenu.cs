using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public async void PlayGame()
    {
        await SceneFader.Instance.FadeOut();

        SceneManager.LoadScene("Monitor");
    }
    public void QuitGame()
    { 
        Application.Quit(); 
    }

}
