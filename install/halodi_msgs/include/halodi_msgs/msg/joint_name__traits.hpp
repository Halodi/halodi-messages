// generated from rosidl_generator_cpp/resource/idl__traits.hpp.em
// with input from halodi_msgs:msg/JointName.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__JOINT_NAME__TRAITS_HPP_
#define HALODI_MSGS__MSG__JOINT_NAME__TRAITS_HPP_

#include "halodi_msgs/msg/joint_name__struct.hpp"
#include <rosidl_generator_cpp/traits.hpp>
#include <stdint.h>
#include <type_traits>

namespace rosidl_generator_traits
{

template<>
inline const char * data_type<halodi_msgs::msg::JointName>()
{
  return "halodi_msgs::msg::JointName";
}

template<>
struct has_fixed_size<halodi_msgs::msg::JointName>
  : std::integral_constant<bool, true> {};

template<>
struct has_bounded_size<halodi_msgs::msg::JointName>
  : std::integral_constant<bool, true> {};

template<>
struct is_message<halodi_msgs::msg::JointName>
  : std::true_type {};

}  // namespace rosidl_generator_traits

#endif  // HALODI_MSGS__MSG__JOINT_NAME__TRAITS_HPP_
