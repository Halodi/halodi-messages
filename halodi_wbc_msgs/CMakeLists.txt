cmake_minimum_required(VERSION 3.5)

project(halodi_wbc_msgs)

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
find_package(halodi_definitions REQUIRED)

rosidl_generate_interfaces(${PROJECT_NAME}
        "msg/DrivingCommand.idl"
        "msg/TaskSpaceCommand.idl"
        "msg/JointSpaceCommand.idl"
	"msg/WholeBodyControllerCommand.idl"
	"msg/SpatialAcceleration.idl"
	"msg/FeedbackParametersSE3.idl"
	"msg/FeedbackParameters3D.idl"
	"msg/DisableWholeBodyBalance.idl"
	DEPENDENCIES rcl_interfaces builtin_interfaces geometry_msgs halodi_definitions
	ADD_LINTER_TESTS
)


ament_package()
