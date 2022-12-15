using System.Collections;
using UnityEngine;

namespace Anakron.Infrastructure
{
    public interface ICoroutineRunner
    {
        public Coroutine StartCoroutine(IEnumerator enumerator);
    }
}