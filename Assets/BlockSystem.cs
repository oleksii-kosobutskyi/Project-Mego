using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSystem : MonoBehaviour {

    [SerializeField]
    private BlockType[] allBlockTypes;

    [HideInInspector]
    public Dictionary<int, Block> allBlocks = new Dictionary<int, Block>();

    private void Awake() {
        for (int i = 0; i < allBlockTypes.Length; i++) {
            BlockType newBlockType = allBlockTypes[i];
            Block newBlock = new Block(i, newBlockType.blockName, newBlockType.blockMaterial);
            allBlocks[i] = newBlock;
            Debug.Log("Block added to dictionary " + allBlocks[i].blockName);
        }
    }
}

public class Block {
    public int blockID;
    public string blockName;
    public Material blockMaterial;

    public Block (int id, string name, Material material) {
        blockID = id;
        blockName = name;
        blockMaterial = material;
    }
}

[Serializable]
public struct BlockType {
    public string blockName;
    public Material blockMaterial;
}
