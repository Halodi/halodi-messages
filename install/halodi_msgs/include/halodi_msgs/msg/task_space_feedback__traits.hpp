// generated from rosidl_generator_cpp/resource/idl__traits.hpp.em
// with input from halodi_msgs:msg/TaskSpaceFeedback.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__TASK_SPACE_FEEDBACK__TRAITS_HPP_
#define HALODI_MSGS__MSG__TASK_SPACE_FEEDBACK__TRAITS_HPP_

#include "halodi_msgs/msg/task_space_feedback__struct.hpp"
#include <rosidl_generator_cpp/traits.hpp>
#include <stdint.h>
#include <type_traits>

// Include directives for member types
// Member 'body_frame'
// Member 'expressed_in_frame'
#include "halodi_msgs/msg/reference_frame_name__traits.hpp"
// Member 'angular_acceleration'
// Member 'linear_acceleration'
#include "geometry_msgs/msg/vector3__traits.hpp"
// Member 'passivity_output'
#include "halodi_msgs/msg/passivity_data__traits.hpp"

namespace rosidl_generator_traits
{

template<>
inline const char * data_type<halodi_msgs::msg::TaskSpaceFeedback>()
{
  return "halodi_msgs::msg::TaskSpaceFeedback";
}

template<>
struct has_fixed_size<halodi_msgs::msg::TaskSpaceFeedback>
  : std::integral_constant<bool, false> {};

template<>
struct has_bounded_size<halodi_msgs::msg::TaskSpaceFeedback>
  : std::integral_constant<bool, has_bounded_size<geometry_msgs::msg::Vector3>::value && has_bounded_size<halodi_msgs::msg::PassivityData>::value && has_bounded_size<halodi_msgs::msg::ReferenceFrameName>::value> {};

template<>
struct is_message<halodi_msgs::msg::TaskSpaceFeedback>
  : std::true_type {};

}  // namespace rosidl_generator_traits

#endif  // HALODI_MSGS__MSG__TASK_SPACE_FEEDBACK__TRAITS_HPP_
