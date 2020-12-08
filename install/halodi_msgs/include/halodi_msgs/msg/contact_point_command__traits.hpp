// generated from rosidl_generator_cpp/resource/idl__traits.hpp.em
// with input from halodi_msgs:msg/ContactPointCommand.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__CONTACT_POINT_COMMAND__TRAITS_HPP_
#define HALODI_MSGS__MSG__CONTACT_POINT_COMMAND__TRAITS_HPP_

#include "halodi_msgs/msg/contact_point_command__struct.hpp"
#include <rosidl_generator_cpp/traits.hpp>
#include <stdint.h>
#include <type_traits>

// Include directives for member types
// Member 'parent_joint'
#include "halodi_msgs/msg/joint_name__traits.hpp"
// Member 'normal'
#include "geometry_msgs/msg/vector3__traits.hpp"

namespace rosidl_generator_traits
{

template<>
inline const char * data_type<halodi_msgs::msg::ContactPointCommand>()
{
  return "halodi_msgs::msg::ContactPointCommand";
}

template<>
struct has_fixed_size<halodi_msgs::msg::ContactPointCommand>
  : std::integral_constant<bool, false> {};

template<>
struct has_bounded_size<halodi_msgs::msg::ContactPointCommand>
  : std::integral_constant<bool, has_bounded_size<geometry_msgs::msg::Vector3>::value && has_bounded_size<halodi_msgs::msg::JointName>::value> {};

template<>
struct is_message<halodi_msgs::msg::ContactPointCommand>
  : std::true_type {};

}  // namespace rosidl_generator_traits

#endif  // HALODI_MSGS__MSG__CONTACT_POINT_COMMAND__TRAITS_HPP_
