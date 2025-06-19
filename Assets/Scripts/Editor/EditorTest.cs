using NUnit.Framework;
using UnityEngine;

public class EditorTest
{
    [Test]
    public void Test()
    {
        var n = 1;
        n += 2;
        Assert.AreEqual(3, n);
    }
}
