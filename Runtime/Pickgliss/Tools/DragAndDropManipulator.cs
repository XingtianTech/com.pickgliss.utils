using UnityEngine.UIElements;

namespace Pickgliss.Tools
{
    public abstract class DragAndDropManipulator : PointerManipulator
    {
        protected VisualElement Root { get; }
        public DragAndDropManipulator(VisualElement target)
        {
            this.target = target;
            Root = target.parent;
        }

        protected override void RegisterCallbacksOnTarget()
        {
            target.RegisterCallback<PointerDownEvent>(PointerDownHandler);
            target.RegisterCallback<PointerMoveEvent>(PointerMoveHandler);
            target.RegisterCallback<PointerUpEvent>(PointerUpHandler);
        }

        protected override void UnregisterCallbacksFromTarget()
        {
            target.UnregisterCallback<PointerDownEvent>(PointerDownHandler);
            target.UnregisterCallback<PointerMoveEvent>(PointerMoveHandler);
            target.UnregisterCallback<PointerUpEvent>(PointerUpHandler);
        }


        protected abstract void PointerDownHandler(PointerDownEvent evt);
        protected abstract void PointerMoveHandler(PointerMoveEvent evt);

        protected abstract void PointerUpHandler(PointerUpEvent evt);

    }
}