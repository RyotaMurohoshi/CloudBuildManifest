using System;
using UnityEngine;

#pragma warning disable 649
namespace CloudBuildManifest {
    /// <summary>Class <c>BuildManifest</c> provides build information for Unity Cloud Build.</summary>
    [Serializable]
    public class BuildManifest
    {
        /// <summary>
        /// If binary is built with Unity Cloud Build, static method <c>Load</c> returns the BuildManifest instance.
        /// If binary is not built with Unity Cloud Build, static method <c>Load</c> returns null.
        /// </summary>
        /// <returns>The BuildManifest instance or null.</returns>
        public static BuildManifest Load()
        {
            var json = LoadManifestAsset();
            if (json == null)
            {
                return null;
            }
            else
            {
                return JsonUtility.FromJson<BuildManifest>(json.text);
            }
        }

        /// <summary>
        /// If binary is built with Unity Cloud Build, static method <c>HasBuildManifest</c> returns true.
        /// If binary is not built with Unity Cloud Build, static method <c>HasBuildManifest</c> returns false.
        /// </summary>
        /// <returns>boolean</returns>
        public static bool HasBuildManifest()
        {
            return LoadManifestAsset() != null;
        }

        private static TextAsset LoadManifestAsset()
        {
            return Resources.Load<TextAsset>("UnityCloudBuildManifest.json");
        }

        [SerializeField]
        string scmCommitId;

        /// <value>Property <c>ScmCommitId</c> represents the commit or changelist that was built.</value>
        public string ScmCommitId { get { return scmCommitId; } }

        [SerializeField]
        string scmBranch;
        /// <value>Property <c>ScmBranch</c> represents the name of the branch that was built.</value>
        public string ScmBranch { get { return scmBranch; } }

        [SerializeField]
        string buildNumber;
        /// <value>Property <c>BuildNumber</c> represents The Unity Cloud Build “build number” corresponding to this build.</value>
        public string BuildNumber { get { return buildNumber; } }

        [SerializeField]
        string buildStartTime;
        /// <value>Property <c>BuildStartTime</c> represents The UTC timestamp when the build process was started.</value>
        public string BuildStartTime { get { return buildStartTime; } }

        [SerializeField]
        string projectId;
        /// <value>Property <c>ProjectId</c> represents The Unity project identifier.</value>
        public string ProjectId { get { return projectId; } }

        [SerializeField]
        string bundleId;
        /// <value>Property <c>BundleId</c> represents The bundleIdentifier configured in Unity Cloud Build (iOS and Android only).</value>
        public string BundleId { get { return bundleId; } }

        [SerializeField]
        string unityVersion;
        /// <value>Property <c>UnityVersion</c> represents The version of Unity that Unity Cloud Build used to create the build.</value>
        public string UnityVersion { get { return unityVersion; } }

        [SerializeField]
        string xcodeVersion;
        /// <value>Property <c>XCodeVersion</c> represents The version of XCode used to build the project (iOS only).</value>
        public string XCodeVersion { get { return xcodeVersion; } }

        [SerializeField]
        string cloudBuildTargetName;
        /// <value>Property <c>CloudBuildTargetName</c> represents the name of the build target that was built.</value>
        public string CloudBuildTargetName { get { return cloudBuildTargetName; } }
    }
}
#pragma warning restore 649
