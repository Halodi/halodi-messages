// generated from rosidl_generator_cpp/resource/idl__traits.hpp.em
// with input from halodi_msgs:msg/ARMarkers.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__AR_MARKERS__TRAITS_HPP_
#define HALODI_MSGS__MSG__AR_MARKERS__TRAITS_HPP_

#include "halodi_msgs/msg/ar_markers__struct.hpp"
#include <rosidl_generator_cpp/traits.hpp>
#include <stdint.h>
#include <type_traits>

// Include directives for member types
// Member 'header'
#include "std_msgs/msg/header__traits.hpp"
// Member 'markers'
#include "halodi_msgs/msg/ar_marker__traits.hpp"

namespace rosidl_generator_traits
{

template<>
inline const char * data_type<halodi_msgs::msg::ARMarkers>()
{
  return "halodi_msgs::msg::ARMarkers";
}

template<>
struct has_fixed_size<halodi_msgs::msg::ARMarkers>
  : std::integral_constant<bool, false> {};

template<>
struct has_bounded_size<halodi_msgs::msg::ARMarkers>
  : std::integral_constant<bool, has_bounded_size<halodi_msgs::msg::ARMarker>::value && has_bounded_size<std_msgs::msg::Header>::value> {};

template<>
struct is_message<halodi_msgs::msg::ARMarkers>
  : std::true_type {};

}  // namespace rosidl_generator_traits

#endif  // HALODI_MSGS__MSG__AR_MARKERS__TRAITS_HPP_
