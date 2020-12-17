// generated from rosidl_generator_cpp/resource/idl__traits.hpp.em
// with input from halodi_msgs:msg/FeedbackParameters3D.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__FEEDBACK_PARAMETERS3_D__TRAITS_HPP_
#define HALODI_MSGS__MSG__FEEDBACK_PARAMETERS3_D__TRAITS_HPP_

#include "halodi_msgs/msg/feedback_parameters3_d__struct.hpp"
#include <rosidl_generator_cpp/traits.hpp>
#include <stdint.h>
#include <type_traits>

// Include directives for member types
// Member 'proportional'
// Member 'integral'
// Member 'derivative'
#include "geometry_msgs/msg/vector3__traits.hpp"

namespace rosidl_generator_traits
{

template<>
inline const char * data_type<halodi_msgs::msg::FeedbackParameters3D>()
{
  return "halodi_msgs::msg::FeedbackParameters3D";
}

template<>
struct has_fixed_size<halodi_msgs::msg::FeedbackParameters3D>
  : std::integral_constant<bool, false> {};

template<>
struct has_bounded_size<halodi_msgs::msg::FeedbackParameters3D>
  : std::integral_constant<bool, has_bounded_size<geometry_msgs::msg::Vector3>::value> {};

template<>
struct is_message<halodi_msgs::msg::FeedbackParameters3D>
  : std::true_type {};

}  // namespace rosidl_generator_traits

#endif  // HALODI_MSGS__MSG__FEEDBACK_PARAMETERS3_D__TRAITS_HPP_
