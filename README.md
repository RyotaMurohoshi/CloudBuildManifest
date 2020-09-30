# CloudBuildManifest

`CloudBuildManifest` is library to get build information for `Unity Cloud Build`.

It is so important to get accurately build version and build commit of running game in user device for debugging. `CloudBuildManifest` provides build information from unity game that is built with `Unity Cloud Build`.

## Install via Package Manager

[Git](https://git-scm.com/) must be installed and added to your path.

The following line needs to be added to your `Packages/manifest.json` file in your Unity Project under the `dependencies` section:

```json
"com.ryotamurohoshi.cloudbuildmanifest": "https://github.com/RyotaMurohoshi/CloudBuildManifest.git#v0.0.1",
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
    buildInfoText = "XXXXXXX #0";
}
```

Please call `BuildManifest.Load()`. If the running game app is not built with `Unity Cloud Build`, the method returns null. If the running game app is built with `Unity Cloud Build`, the method returns valid instance. CloudBuildManifest instance has next properties.

* ScmCommitId
* ScmBranch
* BuildNumber
* BuildStartTime
* ProjectId
* BundleId
* UnityVersion
* XCodeVersion
* CloudBuildTargetName

For properties detail, please refer [Build manifest](https://docs.unity3d.com/Manual/UnityCloudBuildManifest.html) in Unity Documentation.

## Author

Ryota Murohoshi is game Programmer in Japan.

* Posts:http://qiita.com/RyotaMurohoshi (JPN)
* Twitter:https://twitter.com/RyotaMurohoshi (JPN)

## License

This library is under MIT License.