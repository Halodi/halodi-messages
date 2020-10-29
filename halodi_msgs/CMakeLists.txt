cmake_minimum_required(VERSION 3.5)

project(halodi_msgs)

if(NOT CMAKE_CXX_STANDARD)
  set(CMAKE_CXX_STANDARD 14)
endif()
if(CMAKE_COMPILER_IS_GNUCXX OR CMAKE_CXX_COMPILER_ID MATCHES "Clang")
  add_compile_options(-Wall -Wextra -Wpedantic)
endif()

find_package(ament_cmake REQUIRED)
find_package(rosidl_default_generators REQUIRED)
find_package(rcl_interfaces REQUIRED)
find_package(builtin_interfaces REQUIRED)
find_package(geometry_msgs REQUIRED)
find_package(std_msgs REQUIRED)
find_package(unique_identifier_msgs REQUIRED)

rosidl_generate_interfaces(${PROJECT_NAME}
	"msg/JointName.idl"
	"msg/ReferenceFrameName.idl"
        "msg/DrivingCommand.idl"
        "msg/TaskSpaceCommand.idl"
        "msg/JointSpaceCommand.idl"
        "msg/WholeBodyControllerCommand.idl"
        "msg/FeedbackParameters3D.idl"
        "msg/BalanceMode.idl"
        "msg/ImuMeasurement.idl"
        "msg/ImuName.idl"
        "msg/JointMeasurement.idl"
        "msg/WholeBodyState.idl"
        "msg/WholeBodyTrajectory.idl"
        "msg/WholeBodyTrajectoryPoint.idl"
        "msg/JointNullSpaceConfiguration.idl"
        "msg/TrajectoryInterpolation.idl"
        "msg/DrivingTrajectoryPoint.idl"
        "msg/DrivingTrajectory.idl"
        "msg/ContactPointCommand.idl"
        "msg/ControllerData.idl"
      	"msg/ModeSchedule.idl"
      	"msg/MpcFlattenedController.idl"
      	"msg/MpcInput.idl"
      	"msg/MpcObservation.idl"
      	"msg/MpcState.idl"
      	"msg/MpcTargetTrajectories.idl"

	DEPENDENCIES rcl_interfaces builtin_interfaces geometry_msgs std_msgs unique_identifier_msgs
	ADD_LINTER_TESTS
)


ament_package()
