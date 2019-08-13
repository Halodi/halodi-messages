# Java Typesupport

This directory contains .idl version of geometry_msgs to be used to compile the java definitions of the halodi_msgs. 

Due to naming differences between the .idl files on one hand, and the .idl version generated with the Java .msg parser on the other hand, placing custom copies in this directory is by far the most efficient way to generate the messages.

We assume that the definition of geometry_msgs doesn't change.


## Adding types

To add a common ROS2 type, you need to copy and slightly adjust the .idl generated for Java. 

1) Get the matching definition file from https://github.com/ihmcrobotics/ihmc-java-ros2-communication/tree/develop/ros2-common-interfaces/src/main/generated-idl 
2) Create the matching folder in the java-typesupport (this) folder
3) Place the definition file downloaded in step 1 in the folder created in step 2, removing the "_" at the end of the filename, before ".idl"
4) Edit the definition file and remove the "module dds {" line and the corresponding closing tag "};"
5) Remove trailing underscores at the end of the filenames, before ".idl", in the #include tags.
