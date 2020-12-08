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

To add this as a dependency to your Java project, add the following to your build.gradle

```
repositories {
    mavenCentral()
    maven { url "http://dl.bintray.com/ihmcrobotics/maven-release" }
    maven { url "http://dl.bintray.com/halodirobotics/maven-release" }
    mavenLocal()
}
```

```
dependencies {
    compile group: "us.ihmc", name: "euclid-geometry", version: "0.12.0"
    compile group: "us.ihmc", name: "ihmc-pub-sub", version: "0.10.3"
    compile group: "us.ihmc", name: "ros2-common-interfaces", version: "0.13.4"
    compile group: "com.halodi", name: "halodi-messages", version: "0.0.2"
}
```


### Increasing version number

Before building and publishing the Java and C# libraries, increase the version in the following files

- `build.gradle`
- `halodi-messages-unity-support/Packages/halodi-messages/package.json`


### Building and publishing Java libraries

To compile and publishing to your local maven repository, run

```
rm -r build
gradle jar
gradle publishToMavenLocal
```

To upload to bintray, set `bintrayUsername` and `bintrayApiKey` in `~/.gradle/gradle.properties` and run instead of `gradle publishToMavenLocal`:

```
gradle bintrayUpload
```

### Building and publishing C#/Unity libraries

First, publish the Java library. This regenerates the C# messages.

After that, open the Unity project `halodi-messages-unity-support` in Unity. Go to `Packages` -> `Manage packages in project` and select Publish.
