using UnityEngine;

namespace Anakron.Infrastructure.AssetManagement
{
    public class AssetProvider : IAssetProvider
    {
        public TObject Instantiate<TObject>(string path) where TObject : MonoBehaviour
        {
            return Object.Instantiate(Resources.Load<TObject>(path));
        }

        public GameObject Instantiate(string path, Vector3 position)
        {
            return Object.Instantiate(Resources.Load<GameObject>(path), position, Quaternion.identity);
        }
    }
}