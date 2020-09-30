# CloudBuildManifest

`CloudBuildManifest` is library to get build information for `Unity Cloud Build`.

It is so important to get accurately build version and build commit of running game in user device for debugging. `CloudBuildManifest` provides build information from unity game that is built with `Unity Cloud Build`.

## Install

[Git](https://git-scm.com/) must be installed and added to your path.

The following line needs to be added to your `Packages/manifest.json` file in your Unity Project under the `dependencies` section:
Please replace `TAG_YOU_WANT_TO_USE` to the tag you want to use on GitHub.

```json
"com.ryotamurohoshi.cloudbuildmanifest": "https://github.com/RyotaMurohoshi/CloudBuildManifest.git#TAG_YOU_WANT_TO_USE",
```

## Usage

add `using CloudBuildManifest;` and,

```csharp
string buildInfoText;
if (BuildManifest.HasBuildManifest())
{
    var buildManifest = BuildManifest.Load();
    buildInfoText = $"{buildManifest.CloudBuildTargetName} #{buildManifest.BuildNumber}";
}
else
{
    buildInfoText = "Not Cloud Build";
}
```

Please call `BuildManifest.Load()`. If the running game app is not built with `Unity Cloud Build`, the method returns null. If the running game app is built with `Unity Cloud Build`, the method returns valid instance. CloudBuildManifest instance has next properties.

| Property  | Information |
----|----
| ScmCommitId | The commit or changelist that was built. |
| ScmBranch | The name of the branch that was built. |
| BuildNumber | The Unity Cloud Build “build number” corresponding to this build. |
| BuildStartTime | The UTC timestamp when the build process was started. |
| ProjectId | The Unity project identifier. |
| BundleId | The bundleIdentifier configured in Unity Cloud Build (iOS and Android only). |
| UnityVersion | The version of Unity that Unity Cloud Build used to create the build. |
| XCodeVersion | The version of XCode used to build the project (iOS only). |
| CloudBuildTargetName | The name of the build target that was built. |

For more information, please refer [Build manifest](https://docs.unity3d.com/Manual/UnityCloudBuildManifest.html) in Unity Documentation.

## Author

Ryota Murohoshi is game Programmer in Japan.

* Posts:http://qiita.com/RyotaMurohoshi (JPN)
* Twitter:https://twitter.com/RyotaMurohoshi (JPN)

## License

This library is under MIT License.