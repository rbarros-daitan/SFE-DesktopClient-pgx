using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Deployment.WindowsInstaller;
using System.Runtime.InteropServices;

namespace CustomAction
{
    public class CustomActions
    {

        [DllImport("msi.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern UInt32 MsiEnumRelatedProducts(string strUpgradeCode, int reserved, int iIndex, StringBuilder sbProductCode);

        [CustomAction]
        public static ActionResult CustomAction1(Session session)
        {
            session.Log("Begin UninstallPreviousVersion");
            StringBuilder sbProductCode = new StringBuilder(39);
            int iIndex = 0;

            uint rc = MsiEnumRelatedProducts("{C073617B-17A3-41FC-A371-07CD26181900}", 0, iIndex, sbProductCode);
            if (rc == 0)
            {
                session.Log("PC_PROPERTY = " + sbProductCode);
                session["PC_PROPERTY"] = sbProductCode.ToString();
            }
            else
            {
                session.Log("PREVIOUS VERSION NOT FOUND");
            }

            return ActionResult.Success;
        }
    }
}
