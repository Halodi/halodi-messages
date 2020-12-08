// generated from rosidl_generator_cpp/resource/idl__traits.hpp.em
// with input from halodi_msgs:msg/WholeBodyTrajectoryPoint.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__WHOLE_BODY_TRAJECTORY_POINT__TRAITS_HPP_
#define HALODI_MSGS__MSG__WHOLE_BODY_TRAJECTORY_POINT__TRAITS_HPP_

#include "halodi_msgs/msg/whole_body_trajectory_point__struct.hpp"
#include <rosidl_generator_cpp/traits.hpp>
#include <stdint.h>
#include <type_traits>

// Include directives for member types
// Member 'time_from_start'
#include "builtin_interfaces/msg/duration__traits.hpp"
// Member 'task_space_commands'
#include "halodi_msgs/msg/task_space_command__traits.hpp"
// Member 'joint_space_commands'
#include "halodi_msgs/msg/joint_space_command__traits.hpp"
// Member 'contact_point_commands'
#include "halodi_msgs/msg/contact_point_command__traits.hpp"
// Member 'icp_offset_command'
#include "geometry_msgs/msg/vector3__traits.hpp"

namespace rosidl_generator_traits
{

template<>
inline const char * data_type<halodi_msgs::msg::WholeBodyTrajectoryPoint>()
{
  return "halodi_msgs::msg::WholeBodyTrajectoryPoint";
}

template<>
struct has_fixed_size<halodi_msgs::msg::WholeBodyTrajectoryPoint>
  : std::integral_constant<bool, false> {};

template<>
struct has_bounded_size<halodi_msgs::msg::WholeBodyTrajectoryPoint>
  : std::integral_constant<bool, has_bounded_size<builtin_interfaces::msg::Duration>::value && has_bounded_size<geometry_msgs::msg::Vector3>::value && has_bounded_size<halodi_msgs::msg::ContactPointCommand>::value && has_bounded_size<halodi_msgs::msg::JointSpaceCommand>::value && has_bounded_size<halodi_msgs::msg::TaskSpaceCommand>::value> {};

template<>
struct is_message<halodi_msgs::msg::WholeBodyTrajectoryPoint>
  : std::true_type {};

}  // namespace rosidl_generator_traits

#endif  // HALODI_MSGS__MSG__WHOLE_BODY_TRAJECTORY_POINT__TRAITS_HPP_
