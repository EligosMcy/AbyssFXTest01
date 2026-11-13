using UnityEngine.UI;

namespace UI
{
    public class CustomUnRaycastImage : Image
    {
        protected override void Awake()
        {
            base.Awake();
            raycastTarget = false;
        }
    }
}
