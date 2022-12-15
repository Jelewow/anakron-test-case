using Anakron.Infrastructure.AssetManagement;
using UnityEngine;

namespace Anakron.Infrastructure.Factory
{
    public class GameFactory : IGameFactory
    {
        private readonly IAssetProvider _assetProvider;

        public GameFactory(IAssetProvider assetProvider)
        {
            _assetProvider = assetProvider;
        }
        
        public TObject CreateGameObject<TObject>(string path) where TObject : MonoBehaviour
        {
            return _assetProvider.Instantiate<TObject>(path);
        }
    }
}