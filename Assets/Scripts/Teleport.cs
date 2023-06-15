using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleport : MonoBehaviour
{
    [SerializeField] private string _targetSceneName;
    [SerializeField] private int _ExitNumber;
    private AsyncOperation _loading;
    public static int LastExitNumber { get; private set; }
    public static bool IsTeleported { get; private set; }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        IsTeleported = true;
        LastExitNumber = _ExitNumber;
        BlackScreen.ActivateBlackScreen(true);
        _loading = SceneManager.LoadSceneAsync(_targetSceneName);
        _loading.allowSceneActivation = false;
        StartCoroutine(timeDelay());
    }
    private IEnumerator timeDelay(float time = 0.5f)
    {
        yield return new WaitForSeconds(time);
        _loading.allowSceneActivation = true;
    }
}
