using System.Threading.Tasks;
using UnityEngine;

public class SceneFader : MonoBehaviour
{
    public static SceneFader Instance;
    [SerializeField] CanvasGroup canvasGroup;
    [SerializeField] float fadeDuration = 0.5f;
    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    async Task Fade(float targetTrasnparency)
    {
        float start = canvasGroup.alpha, t = 0;
        while (t < fadeDuration)
        {
            t += Time.deltaTime;
            canvasGroup.alpha = Mathf.Lerp(start, targetTrasnparency, t / fadeDuration);
            await Task.Yield();
        }
        canvasGroup.alpha = targetTrasnparency;
    }

    public async Task FadeOut()
    {
        await Fade(1); //Fade to black
    }

    public async Task FadeIn()
    {
        await Fade(0); //Fade to transparent
    }
}
