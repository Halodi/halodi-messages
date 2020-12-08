// generated from rosidl_typesupport_fastrtps_cpp/resource/idl__rosidl_typesupport_fastrtps_cpp.hpp.em
// with input from halodi_msgs:msg/DrivingTrajectory.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__DRIVING_TRAJECTORY__ROSIDL_TYPESUPPORT_FASTRTPS_CPP_HPP_
#define HALODI_MSGS__MSG__DRIVING_TRAJECTORY__ROSIDL_TYPESUPPORT_FASTRTPS_CPP_HPP_

#include "rosidl_generator_c/message_type_support_struct.h"
#include "rosidl_typesupport_interface/macros.h"
#include "halodi_msgs/msg/rosidl_typesupport_fastrtps_cpp__visibility_control.h"
#include "halodi_msgs/msg/driving_trajectory__struct.hpp"

#ifndef _WIN32
# pragma GCC diagnostic push
# pragma GCC diagnostic ignored "-Wunused-parameter"
# ifdef __clang__
#  pragma clang diagnostic ignored "-Wdeprecated-register"
#  pragma clang diagnostic ignored "-Wreturn-type-c-linkage"
# endif
#endif
#ifndef _WIN32
# pragma GCC diagnostic pop
#endif

#include "fastcdr/Cdr.h"

namespace halodi_msgs
{

namespace msg
{

namespace typesupport_fastrtps_cpp
{

bool
ROSIDL_TYPESUPPORT_FASTRTPS_CPP_PUBLIC_halodi_msgs
cdr_serialize(
  const halodi_msgs::msg::DrivingTrajectory & ros_message,
  eprosima::fastcdr::Cdr & cdr);

bool
ROSIDL_TYPESUPPORT_FASTRTPS_CPP_PUBLIC_halodi_msgs
cdr_deserialize(
  eprosima::fastcdr::Cdr & cdr,
  halodi_msgs::msg::DrivingTrajectory & ros_message);

size_t
ROSIDL_TYPESUPPORT_FASTRTPS_CPP_PUBLIC_halodi_msgs
get_serialized_size(
  const halodi_msgs::msg::DrivingTrajectory & ros_message,
  size_t current_alignment);

size_t
ROSIDL_TYPESUPPORT_FASTRTPS_CPP_PUBLIC_halodi_msgs
max_serialized_size_DrivingTrajectory(
  bool & full_bounded,
  size_t current_alignment);

}  // namespace typesupport_fastrtps_cpp

}  // namespace msg

}  // namespace halodi_msgs

#ifdef __cplusplus
extern "C"
{
#endif

ROSIDL_TYPESUPPORT_FASTRTPS_CPP_PUBLIC_halodi_msgs
const rosidl_message_type_support_t *
  ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_fastrtps_cpp, halodi_msgs, msg, DrivingTrajectory)();

#ifdef __cplusplus
}
#endif

#endif  // HALODI_MSGS__MSG__DRIVING_TRAJECTORY__ROSIDL_TYPESUPPORT_FASTRTPS_CPP_HPP_
