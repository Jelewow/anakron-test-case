using Anakron.Infrastructure.Services;
using UnityEngine;

namespace Anakron.Infrastructure.Factory
{
    public interface IGameFactory : IService
    {
        public TObject CreateGameObject<TObject>(string path) where TObject : MonoBehaviour;
    }
}