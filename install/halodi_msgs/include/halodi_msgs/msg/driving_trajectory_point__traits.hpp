// generated from rosidl_generator_cpp/resource/idl__traits.hpp.em
// with input from halodi_msgs:msg/DrivingTrajectoryPoint.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__DRIVING_TRAJECTORY_POINT__TRAITS_HPP_
#define HALODI_MSGS__MSG__DRIVING_TRAJECTORY_POINT__TRAITS_HPP_

#include "halodi_msgs/msg/driving_trajectory_point__struct.hpp"
#include <rosidl_generator_cpp/traits.hpp>
#include <stdint.h>
#include <type_traits>

namespace rosidl_generator_traits
{

template<>
inline const char * data_type<halodi_msgs::msg::DrivingTrajectoryPoint>()
{
  return "halodi_msgs::msg::DrivingTrajectoryPoint";
}

template<>
struct has_fixed_size<halodi_msgs::msg::DrivingTrajectoryPoint>
  : std::integral_constant<bool, true> {};

template<>
struct has_bounded_size<halodi_msgs::msg::DrivingTrajectoryPoint>
  : std::integral_constant<bool, true> {};

template<>
struct is_message<halodi_msgs::msg::DrivingTrajectoryPoint>
  : std::true_type {};

}  // namespace rosidl_generator_traits

#endif  // HALODI_MSGS__MSG__DRIVING_TRAJECTORY_POINT__TRAITS_HPP_
