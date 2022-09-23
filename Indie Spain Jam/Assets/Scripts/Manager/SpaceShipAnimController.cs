using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipAnimController : MonoBehaviour
{
    [SerializeField] private Animator anim;
    [SerializeField] private UpgradeFood upgrade;

    [SerializeField] private int upgradeValue;
    [SerializeField] private string parameterName;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void updateAnim(int value)
    {
        upgradeValue = value;
        anim.SetInteger(parameterName, upgradeValue);
    }
}
