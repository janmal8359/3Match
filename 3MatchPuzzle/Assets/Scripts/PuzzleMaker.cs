using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PuzzleSet
{
    public int x;
    public int y;
    public float space;
}

public class PuzzleMaker : MonoBehaviour
{
    public PuzzleSet puzzle;
    public RectTransform puzzleBack;
    public GameObject prefNode;

    private Queue<GameObject> nodePool = new Queue<GameObject>();

    void Start()
    {
        SetPuzzleNodes();
    }


    public void SetPuzzleNodes()
    {
        prefNode.TryGetComponent<RectTransform>(out RectTransform nodeRect);

        float width = puzzle.space * (puzzle.x + 1) + nodeRect.rect.width * puzzle.x;
        float height = puzzle.space * (puzzle.y + 1) + nodeRect.rect.height * puzzle.y;

        // puzzleBack Set
        puzzleBack.sizeDelta = new Vector2(width, height);

        // Node Pos
        var node = GetNode();
    }

    GameObject GetNode()
    {
        if (nodePool.Count > 0)
        {
            return nodePool.Dequeue();
        }

        else return Instantiate(prefNode);
    }
}
