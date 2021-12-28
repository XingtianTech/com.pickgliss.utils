using UnityEngine;
namespace Pickgliss.Helper
{
	public class MeshHelper
	{
		public static void CreateMesh (ref Mesh mesh, int numVertices) {
			const int vertexLimit16Bit = 1 << 16 - 1; // 65535
			if (mesh == null) {
				mesh = new Mesh ();
			} else {
				mesh.Clear ();
			}
			mesh.indexFormat = (numVertices < vertexLimit16Bit) ? UnityEngine.Rendering.IndexFormat.UInt16 : UnityEngine.Rendering.IndexFormat.UInt32;
		}
		public static GameObject GetOrCreateMeshObject (GameObject parent, string name, Mesh mesh, Material material) 
		{
			// Find/create object
			var child = parent.transform.Find (name);
			if (!child) {
				child = new GameObject (name).transform;
				child.parent = parent.transform;
				child.localPosition = Vector3.zero;
				child.localRotation = Quaternion.identity;
				child.localScale = Vector3.one;
				child.gameObject.layer = parent.layer;
			}

			// Add mesh components
			MeshFilter filter;
			if (!child.TryGetComponent<MeshFilter> (out filter)) {
				filter = child.gameObject.AddComponent<MeshFilter> ();
			}
			filter.sharedMesh = mesh;

			MeshRenderer renderer;
			if (!child.TryGetComponent<MeshRenderer> (out renderer)) {
				renderer = child.gameObject.AddComponent<MeshRenderer> ();
			}
			renderer.sharedMaterial = material;

			return child.gameObject;
		}
	}
}