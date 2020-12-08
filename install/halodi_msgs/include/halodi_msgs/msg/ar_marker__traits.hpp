// generated from rosidl_generator_cpp/resource/idl__traits.hpp.em
// with input from halodi_msgs:msg/ARMarker.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__AR_MARKER__TRAITS_HPP_
#define HALODI_MSGS__MSG__AR_MARKER__TRAITS_HPP_

#include "halodi_msgs/msg/ar_marker__struct.hpp"
#include <rosidl_generator_cpp/traits.hpp>
#include <stdint.h>
#include <type_traits>

// Include directives for member types
// Member 'points'
#include "geometry_msgs/msg/point__traits.hpp"
// Member 'pose'
#include "geometry_msgs/msg/pose_stamped__traits.hpp"

namespace rosidl_generator_traits
{

template<>
inline const char * data_type<halodi_msgs::msg::ARMarker>()
{
  return "halodi_msgs::msg::ARMarker";
}

template<>
struct has_fixed_size<halodi_msgs::msg::ARMarker>
  : std::integral_constant<bool, false> {};

template<>
struct has_bounded_size<halodi_msgs::msg::ARMarker>
  : std::integral_constant<bool, false> {};

template<>
struct is_message<halodi_msgs::msg::ARMarker>
  : std::true_type {};

}  // namespace rosidl_generator_traits

#endif  // HALODI_MSGS__MSG__AR_MARKER__TRAITS_HPP_
