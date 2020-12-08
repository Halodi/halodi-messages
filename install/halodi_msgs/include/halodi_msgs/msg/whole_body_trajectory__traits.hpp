// generated from rosidl_generator_cpp/resource/idl__traits.hpp.em
// with input from halodi_msgs:msg/WholeBodyTrajectory.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__WHOLE_BODY_TRAJECTORY__TRAITS_HPP_
#define HALODI_MSGS__MSG__WHOLE_BODY_TRAJECTORY__TRAITS_HPP_

#include "halodi_msgs/msg/whole_body_trajectory__struct.hpp"
#include <rosidl_generator_cpp/traits.hpp>
#include <stdint.h>
#include <type_traits>

// Include directives for member types
// Member 'trajectory_id'
#include "unique_identifier_msgs/msg/uuid__traits.hpp"
// Member 'start_time'
#include "builtin_interfaces/msg/time__traits.hpp"
// Member 'balance_mode'
#include "halodi_msgs/msg/balance_mode__traits.hpp"
// Member 'interpolation_mode'
#include "halodi_msgs/msg/trajectory_interpolation__traits.hpp"
// Member 'trajectory_points'
#include "halodi_msgs/msg/whole_body_trajectory_point__traits.hpp"

namespace rosidl_generator_traits
{

template<>
inline const char * data_type<halodi_msgs::msg::WholeBodyTrajectory>()
{
  return "halodi_msgs::msg::WholeBodyTrajectory";
}

template<>
struct has_fixed_size<halodi_msgs::msg::WholeBodyTrajectory>
  : std::integral_constant<bool, false> {};

template<>
struct has_bounded_size<halodi_msgs::msg::WholeBodyTrajectory>
  : std::integral_constant<bool, has_bounded_size<builtin_interfaces::msg::Time>::value && has_bounded_size<halodi_msgs::msg::BalanceMode>::value && has_bounded_size<halodi_msgs::msg::TrajectoryInterpolation>::value && has_bounded_size<halodi_msgs::msg::WholeBodyTrajectoryPoint>::value && has_bounded_size<unique_identifier_msgs::msg::UUID>::value> {};

template<>
struct is_message<halodi_msgs::msg::WholeBodyTrajectory>
  : std::true_type {};

}  // namespace rosidl_generator_traits

#endif  // HALODI_MSGS__MSG__WHOLE_BODY_TRAJECTORY__TRAITS_HPP_
