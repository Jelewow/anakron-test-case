using Anakron.Infrastructure.Services;
using UnityEngine;

namespace Anakron.Infrastructure.AssetManagement
{
    public interface IAssetProvider : IService
    {
        public TObject Instantiate<TObject>(string path) where TObject : MonoBehaviour;
        
        public GameObject Instantiate(string path, Vector3 position);
    }
}