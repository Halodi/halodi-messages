// generated from rosidl_generator_cpp/resource/idl__traits.hpp.em
// with input from halodi_msgs:msg/TaskSpaceCommand.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__TASK_SPACE_COMMAND__TRAITS_HPP_
#define HALODI_MSGS__MSG__TASK_SPACE_COMMAND__TRAITS_HPP_

#include "halodi_msgs/msg/task_space_command__struct.hpp"
#include <rosidl_generator_cpp/traits.hpp>
#include <stdint.h>
#include <type_traits>

// Include directives for member types
// Member 'body_frame'
// Member 'expressed_in_frame'
#include "halodi_msgs/msg/reference_frame_name__traits.hpp"
// Member 'pose'
#include "geometry_msgs/msg/pose__traits.hpp"
// Member 'angular_velocity'
// Member 'linear_velocity'
// Member 'angular_acceleration'
// Member 'linear_acceleration'
#include "geometry_msgs/msg/vector3__traits.hpp"
// Member 'passivity_input'
#include "halodi_msgs/msg/passivity_data__traits.hpp"
// Member 'orientation_feedback_parameters'
// Member 'position_feedback_parameters'
#include "halodi_msgs/msg/feedback_parameters3_d__traits.hpp"
// Member 'nullspace_command'
#include "halodi_msgs/msg/joint_null_space_configuration__traits.hpp"

namespace rosidl_generator_traits
{

template<>
inline const char * data_type<halodi_msgs::msg::TaskSpaceCommand>()
{
  return "halodi_msgs::msg::TaskSpaceCommand";
}

template<>
struct has_fixed_size<halodi_msgs::msg::TaskSpaceCommand>
  : std::integral_constant<bool, false> {};

template<>
struct has_bounded_size<halodi_msgs::msg::TaskSpaceCommand>
  : std::integral_constant<bool, has_bounded_size<geometry_msgs::msg::Pose>::value && has_bounded_size<geometry_msgs::msg::Vector3>::value && has_bounded_size<halodi_msgs::msg::FeedbackParameters3D>::value && has_bounded_size<halodi_msgs::msg::JointNullSpaceConfiguration>::value && has_bounded_size<halodi_msgs::msg::PassivityData>::value && has_bounded_size<halodi_msgs::msg::ReferenceFrameName>::value> {};

template<>
struct is_message<halodi_msgs::msg::TaskSpaceCommand>
  : std::true_type {};

}  // namespace rosidl_generator_traits

#endif  // HALODI_MSGS__MSG__TASK_SPACE_COMMAND__TRAITS_HPP_
