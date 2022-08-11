cmake_minimum_required(VERSION 3.5)

project(ocs2_ros2_msgs)

if(NOT CMAKE_CXX_STANDARD)
  set(CMAKE_CXX_STANDARD 14)
endif()
if(CMAKE_COMPILER_IS_GNUCXX OR CMAKE_CXX_COMPILER_ID MATCHES "Clang")
  add_compile_options(-Wall -Wextra -Wpedantic)
endif()

find_package(ament_cmake REQUIRED)
find_package(rosidl_default_generators REQUIRED)
find_package(std_msgs REQUIRED)

rosidl_generate_interfaces(${PROJECT_NAME}
  "msg/MpcState.idl"
  "msg/MpcInput.idl"
	"msg/ModeSchedule.idl"
  "msg/MpcObservation.idl"
  "msg/MpcPerformanceIndices.idl"
  "msg/MpcTargetTrajectories.idl"
	"msg/ControllerData.idl"
  "msg/MpcFlattenedController.idl"
  "srv/Reset.srv"

  DEPENDENCIES std_msgs

)

ament_package()