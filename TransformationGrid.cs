using UnityEngine;

public class TransformationGrid : MonoBehaviour {

	public Transform prefab;

	public int gridResolution = 10;

	Transform[] grid;

	void Awake () {
		grid = new Transform[gridResolution * gridResolution * gridResolution];
		for (int i = 0, z = 0; z < gridResolution; z++) {
			for (int y = 0; y < gridResolution; y++) {
				for (int x = 0; x < gridResolution; x++, i++) {
					grid[i] = CreateGridPoint(x, y, z);
				}
			}
		}
	}
}
