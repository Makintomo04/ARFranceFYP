using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using UnityEngine;
using UnityEngine.XR.WindowsMR;

using UnityEditor;
using UnityEditor.XR.Management;

namespace UnityEditor.XR.WindowsMR
{
    class WindowsMRXRSDKPackageInitialization : XRPackageInitializationBase
    {
        public string PackageName { get { return "Windows MR XR SDK"; } }
        public string LoaderFullTypeName { get { return "UnityEngine.XR.WindowsMR.WindowsMRLoader"; } }
        public string LoaderTypeName { get { return "WindowsMRLoader"; } }
        public string SettingsFullTypeName { get{ return "UnityEditor.XR.WindowsMR.WindowsMRPackageSettings"; } }
        public string SettingsTypeName { get{ return "WindowsMRPackageSettings"; } }
        public string PackageInitKey { get { return "Windows MR Package Initialization"; } }

        /// <summary>Will populate default settings on package initialization.</summary>
        /// <param name="obj">The scriptable object instance from the Asset Database that is an instance of WindowsMRPacakgeSettings</param>
        /// <returns>True if settings were populated, else false.</returns>
        /// <seealso cref="WindowsMRPackageSettings" />
        public bool PopulateSettingsOnInitialization(ScriptableObject obj)
        {
            WindowsMRPackageSettings packageSettings = obj as WindowsMRPackageSettings;
            if (packageSettings != null)
            {
                var settings = packageSettings.GetSettingsForBuildTargetGroup(BuildTargetGroup.WSA);
                if (settings != null)
                {
                    switch (PlayerSettings.VRWindowsMixedReality.depthBufferFormat)
                    {
                    case PlayerSettings.VRWindowsMixedReality.DepthBufferFormat.DepthBufferFormat16Bit:
                        settings.DepthBufferFormat = WindowsMRSettings.DepthBufferOption.DepthBuffer16Bit;
                        break;
                    case PlayerSettings.VRWindowsMixedReality.DepthBufferFormat.DepthBufferFormat24Bit:
                        settings.DepthBufferFormat = WindowsMRSettings.DepthBufferOption.DepthBuffer24Bit;
                        break;
                    }

                    settings.UseSharedDepthBuffer = PlayerSettings.VRWindowsMixedReality.depthBufferSharingEnabled;
                    return true;
                }
            }
            return false;
        }

    }
}
