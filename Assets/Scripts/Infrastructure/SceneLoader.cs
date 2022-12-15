using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Anakron.Infrastructure
{
    public class SceneLoader
    {
        private readonly ICoroutineRunner _coroutineRunner;

        public SceneLoader(ICoroutineRunner coroutineRunner)
        {
            _coroutineRunner = coroutineRunner;
        }

        public void Load(string name, Action callback = null)
        {
            _coroutineRunner.StartCoroutine(LoadScene(name, callback));
        }

        private IEnumerator LoadScene(string name, Action callback = null)
        {
            if (SceneManager.GetActiveScene().name == name)
            {
                callback?.Invoke();
                yield break;
            }

            var waitNextScene = SceneManager.LoadSceneAsync(name);
            yield return new WaitUntil(() => waitNextScene.isDone);
            
            callback?.Invoke();
        }
    }
}