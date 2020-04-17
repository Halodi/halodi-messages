# API

This document contains a brief introduction to the API. For more information about the datatypes, see the documentation inside the messages definitions(.idl) in the [halodi_msgs/msg](halodi_msgs/msg) folder.

## Status messages

#### /eve/whole_body_state
- Rate: 250Hz
- Data type: [halodi_msgs/msg/WholeBodyState.idl](halodi_msgs/msg/WholeBodyState.idl)

This topic publishes the state of the robot. A custom data type is used to describe the whole state of the robot, to allow receiving an atomic state. 

#### /eve/whole_body_trajectory_status
- Data type: [action_msgs/msg/GoalStatus.msg](https://github.com/ros2/rcl_interfaces/blob/master/action_msgs/msg/GoalStatus.msg)

This topic is used to provide feedback of commands send to /eve/whole_body_trajectory. Note that it does not use the action API.

STATUS_EXECUTING is published for every poin tin the trajectory.

If no trajectory_id is set in the WholeBodyTrajectory, no feedback will be generated. 


#### /tf
- Rate: 250Hz
- Data type: [tf2_msgs/msg/TFMessage.msg](https://github.com/ros2/geometry2/blob/ros2/tf2_msgs/msg/TFMessage.msg)

This topic publishes standard TF2 information. The root transform is called "World".


## Control messages

The robot can be controlled with the Trajectory API or the Realtime API.

We recommend using the trajectory API, as this does not put realtime constraints on the user application and is easier to use.

### Trajectory API
The trajectory API is a high level API that can interpolate trajectories trough points in task space and joint space. The following topics are available:


#### /eve/whole_body_trajectory
- Data type: [halodi_msgs/msg/WholeBodyTrajectory.idl](halodi_msgs/msg/WholeBodyTrajectory.idl)

This topic is to send trajectories. It is recommended to keep the number of points in the trajectory to a reasonable number (~16 maximum) to avoid large messages that can get lost on the network.

To avoid large velocities, keep a reasonable minimum time between points. 

The maximum supported rate to send messages is 50Hz.


#### /eve/driving_command
- Data rate: Minimum 10Hz
- Data type: [halodi_msgs/msg/DrivingCommand.idl](halodi_msgs/msg/DrivingCommand.idl)

Send linear and angular velocities to the controller. A timeout of about 100ms (robot time/simulation time) is implemented to avoid the robot driving uncontrollable if communication gets lost.

### Realtime API

The realtime API allows the fastest control updates for the user, but the user is responsible for updating the setpoints at 250Hz. This puts a soft-realtime requirement on the user controller. Missed deadlines will not result in a fall, but could result in a jump in setpoints.

The realtime API is used by the trajectory manager, and therefore cannot be used if the trajectory manager is in use.

Topics: 
#### /eve/whole_body_command
- Rate: 250Hz
- [halodi_msgs/msg/WholeBodyControllerCommand.idl](halodi_msgs/msg/WholeBodyControllerCommand.idl)

The recommended implementation is to block on /eve/whole_body_trajectory_status and publish a command every time a new whole_body_trajectory_status is received. 

Note: In simulation, the controller can run at a different rate than realtime. Hence it is not recommended to publish based on the system clock.
