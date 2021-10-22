# Halodi-messages

This repository contains custom ROS2/IDL messages from Halodi Robotics. These form the main API for the Halodi controller.

## API Quickstart

[API Quickstart Guide](API.md)


## Using with ROS2

This repository contains the halodi_msgs ROS2 package. Checkout this repository in the 'src/' folder of your ROS2 workspace to compile.

For information to setup the halodi-controller in simulation, go to [halodi-controller](https://github.com/Halodi/halodi-controller).


## Using with IHMC ROS2 Libraries

This repository builds against the IHMC ROS2 libraries and generates compatible Java files. 


### Adding as dependency

To add this as a dependency to your Java project, find the release here and the how to use it:
https://artifacts.halodi.cloud/#browse/browse:maven-open:com%2Fhalodi%2Fhalodi-messages

```
repositories {
    ...
    maven { url "https://artifacts.halodi.cloud/repository/maven-open/" }
    ...
}
```



### Building and publishing Java libraries

To compile and publishing to your local maven repository, run

```
rm -r build
gradle jar
gradle publishToMavenLocal -PartifactVersion=[version] -PenvironmentName=release
```

To upload snapshot to artifacts.halodi.com:
```
ARTIFACT_USERNAME=[username] ARTIFACT_PASSWORD=[password] ARTIFACT_VERSION=[version] gradle publish
```

### Building and publishing C#/Unity libraries

First, publish the Java library. This regenerates the C# messages.

After that, open the Unity project `halodi-messages-unity-support` in Unity. Go to `Packages` -> `Manage packages in project` and select Publish.
