using UnityEngine;

namespace Wheel_of_Luck.Scripts.Common
{
    public abstract class BaseAdapter<T>
    {
        protected T AssetPackage;

        protected BaseAdapter(GameObject asset)
        {
            AssetPackage = asset.GetComponent<T>();
        }

        public abstract void Init();

        public abstract void CleanUp();
    }
}