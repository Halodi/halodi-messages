// generated from rosidl_generator_cpp/resource/idl__traits.hpp.em
// with input from halodi_msgs:msg/JointStatus.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__JOINT_STATUS__TRAITS_HPP_
#define HALODI_MSGS__MSG__JOINT_STATUS__TRAITS_HPP_

#include "halodi_msgs/msg/joint_status__struct.hpp"
#include <rosidl_generator_cpp/traits.hpp>
#include <stdint.h>
#include <type_traits>

// Include directives for member types
// Member 'joint'
#include "halodi_msgs/msg/joint_name__traits.hpp"

namespace rosidl_generator_traits
{

template<>
inline const char * data_type<halodi_msgs::msg::JointStatus>()
{
  return "halodi_msgs::msg::JointStatus";
}

template<>
struct has_fixed_size<halodi_msgs::msg::JointStatus>
  : std::integral_constant<bool, has_fixed_size<halodi_msgs::msg::JointName>::value> {};

template<>
struct has_bounded_size<halodi_msgs::msg::JointStatus>
  : std::integral_constant<bool, has_bounded_size<halodi_msgs::msg::JointName>::value> {};

template<>
struct is_message<halodi_msgs::msg::JointStatus>
  : std::true_type {};

}  // namespace rosidl_generator_traits

#endif  // HALODI_MSGS__MSG__JOINT_STATUS__TRAITS_HPP_
