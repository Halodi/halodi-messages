# API

This document contains a brief introduction to the API. For more information about the datatypes, see the documentation inside the messages definitions(.idl) in the [halodi_msgs/msg](halodi_msgs/msg) folder.

## Status messages

#### /eve/whole_body_state
- Rate: 500Hz
- Data type: [halodi_msgs/msg/WholeBodyState.idl](halodi_msgs/msg/WholeBodyState.idl)
- Reliability QOS: Best Effort

This topic publishes the state of the robot. A custom data type is used to describe the whole state of the robot, to allow receiving an atomic state. 

#### /eve/whole_body_trajectory_status
- Data type: [action_msgs/msg/GoalStatus.msg](https://github.com/ros2/rcl_interfaces/blob/master/action_msgs/msg/GoalStatus.msg)
- Reliability QOS: Reliable

This topic is used to provide feedback of commands send to /eve/whole_body_trajectory. Note that it does not use the action API.

STATUS_EXECUTING is published for every poin tin the trajectory.

If no trajectory_id is set in the WholeBodyTrajectory, no feedback will be generated. 


#### /eve/accepting_trajectories
- Data rate: 500Hz
- Data type: [std_msgs/msg/Bool.msg](https://github.com/ros2/common_interfaces/blob/master/std_msgs/msg/Bool.msg)
- Reliablity QOS: Best effort

Published if the Trajectory API is active. When the API is active, this topic will be set to true. If the API is active, but the controller is not accepting messages, this will be false. If not published, the trajectory API is not active.
It is recommended to only publish to /eve/whole_body_trajectory if this is true.


#### /eve/status
- Rate: 5Hz
- Data type: [halodi_msgs/msg/RobotStatus.idl](https://github.com/Halodi/halodi-messages/blob/master/halodi_msgs/msg/RobotStatus.idl)
- Reliablity: Best Effort

This topic provides the system status of the robot and includes
- E-Stop status
- Battery status
- Motor status and temperature

#### /clock
- Rate: 500Hz
- Data type: [rosgraph_msgs/msg/Clock.msg](https://github.com/ros2/rcl_interfaces/blob/master/rosgraph_msgs/msg/Clock.msg)
- Reliablity QOS: Best effort

This topic provides the ROS clock.

#### /tf
- Rate: 500Hz
- Data type: [tf2_msgs/msg/TFMessage.msg](https://github.com/ros2/geometry2/blob/ros2/tf2_msgs/msg/TFMessage.msg)
- Reliability QOS: Best Effort

This topic publishes standard TF2 information. The root transform is called "World".

#### /eve/hand_status
- Rate: ~100Hz (depends on hand option chosen)
- Data type: [sensors_msgs/msg/JointState.msg](https://github.com/ros2/common_interfaces/blob/master/sensor_msgs/msg/JointState.msg)
- Reliablilty QOS: Best effort

For each hand, joint state
- Position: Closure rate  of the hand (0 - 1)
- Velocity: Relative velocity of the hand if supported
- Effort: Relative effort of the hand if supported


## Lifecycle messages

Lifecycle messages can stop the controller and clear certain error states

#### /eve/stop_command
- Data type: [halodi_msgs/msg/StopCommand.idl](halodi_msgs/msg/StopCommand.idl)
- Reliability QOS: Reliable

Using the stop command, the user can instruct the robot to freeze, go to default pose and clear motor errors, resume normal operation and shutdown the robot.


## Control messages

The robot can be controlled with the Trajectory API or the Realtime API.

We recommend using the trajectory API, as this does not put realtime constraints on the user application and is easier to use.

### Trajectory API
The trajectory API is a high level API that can interpolate trajectories trough points in task space and joint space. The following topics are available:





#### /eve/whole_body_trajectory
- Data type: [halodi_msgs/msg/WholeBodyTrajectory.idl](halodi_msgs/msg/WholeBodyTrajectory.idl)
- Reliablility QOS: Reliable

This topic is to send trajectories. It is recommended to keep the number of points in the trajectory to a reasonable number (~16 maximum) to avoid large messages that can get lost on the network.

To avoid large velocities, keep a reasonable minimum time between points. 

The maximum supported rate to send messages is 50Hz.


#### /eve/driving_command
- Data rate: Minimum 10Hz
- Data type: [halodi_msgs/msg/DrivingCommand.idl](halodi_msgs/msg/DrivingCommand.idl)
- Reliablility QOS: Reliable

Send linear and angular velocities to the controller. A timeout of about 100ms (robot time/simulation time) is implemented to avoid the robot driving uncontrollable if communication gets lost.

### Realtime API

The realtime API allows the fastest control updates for the user, but the user is responsible for updating the setpoints at 250Hz. This puts a soft-realtime requirement on the user controller. Missed deadlines will not result in a fall, but could result in a jump in setpoints.

The realtime API is used by the trajectory manager, and therefore cannot be used if the trajectory manager is in use.

Subscribers:
#### /eve/whole_body_command
- Rate: 500Hz
- [halodi_msgs/msg/WholeBodyControllerCommand.idl](halodi_msgs/msg/WholeBodyControllerCommand.idl)
- Reliablility QOS: Best effort

The recommended implementation is to block on /eve/whole_body_trajectory_status and publish a command every time a new whole_body_trajectory_status is received. 

Note: In simulation, the controller can run at a different rate than realtime. Hence it is not recommended to publish based on the system clock.

### Hands

Topics:
#### /eve/hand_closure
- Rate: Up to 100Hz, depends on publisher
- [halodi_msgs/msg/HandCommand.idl](halodi_msgs/msg/HandCommand.idl)
- Reliablility QOS: Best Effort

### Navigation and mapping

These topics are used to update the pose estimate of the robot in map frame

Subscribers:
#### /eve/estimated_pose_config
- Rate: Single shot
- [halodi_msgs/msg/RobotPoseEstimateConfiguration.idl](halodi_msgs/msg/RobotPoseEstimateConfiguration.idl)
- Reliablility QOS: Reliable
- Durability QOS: Transient Local


Configuration element for the estimated pose updates. Publish using transient local so later connections still get the update

#### /eve/estimated_pose
- Rate: Up to 500Hz
- [geometry_msgs/msg/PoseWithCovarianceStamped.msg](https://github.com/ros2/common_interfaces/blob/master/geometry_msgs/msg/PoseWithCovarianceStamped.msg)
- Reliability QOS: Best Effort

Robot pose from external estimator to calculate the map_pose in the whole body state.
