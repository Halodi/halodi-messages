# Halodi-messages

This repository contains custom ROS2/IDL messages from Halodi Robotics.

## Using with ROS2

This repository is a valid ROS2 package. Checkout in the 'src/' folder of your ROS2 workspace to compile.

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
    compile group: "com.halodi", name: "halodi-messages", version: "0.0.1"
}
```


### Building and publishing Java libraries

To compile and publishing to your local maven repository, run

```
gradle publishToMavenLocal
```

To upload to bintray, set `bintrayUsername` and `bintrayApiKey` in `~/.gradle/gradle.properties` and run

```
gradle bintrayUPload
```
