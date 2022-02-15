using UnityEngine;

public class ResourcesExtension : MonoBehaviour
{ 
    private string _resourcesPath = "Initializer/";
    private string _UIResourcesPath = "Initializer/UI/";

    public T Load<T>() where T : Object
    {
        T prefab = Resources.Load<T>(_resourcesPath + typeof(T));
        return Instantiate(prefab);
    }

    public T LoadUI<T>(Canvas canvas) where T : Object
    {
        T prefab = Resources.Load<T>(_UIResourcesPath + typeof(T));
        var instancedObject = Instantiate(prefab, canvas.transform);

        return instancedObject;
    }
}
