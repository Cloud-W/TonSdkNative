using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class TonCsharpBridge : MonoBehaviour
{

    [DllImport("__Internal")]
    private static extern void GetWallets();

    [DllImport("__Internal")]
    private static extern void Connect();

    [DllImport("__Internal")]
    private static extern void TestPay();

    public void OnConnectClick()
    {
        Connect();
    }

    public void OnGetWalletClick()
    {
        GetWallets();
    }

    public void OnTestPay()
    {
        TestPay();
    }
}
