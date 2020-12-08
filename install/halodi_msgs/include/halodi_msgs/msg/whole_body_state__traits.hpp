// generated from rosidl_generator_cpp/resource/idl__traits.hpp.em
// with input from halodi_msgs:msg/WholeBodyState.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__WHOLE_BODY_STATE__TRAITS_HPP_
#define HALODI_MSGS__MSG__WHOLE_BODY_STATE__TRAITS_HPP_

#include "halodi_msgs/msg/whole_body_state__struct.hpp"
#include <rosidl_generator_cpp/traits.hpp>
#include <stdint.h>
#include <type_traits>

// Include directives for member types
// Member 'header'
#include "std_msgs/msg/header__traits.hpp"
// Member 'current_balance_mode'
#include "halodi_msgs/msg/balance_mode__traits.hpp"
// Member 'pose'
#include "geometry_msgs/msg/pose__traits.hpp"
// Member 'angular_velocity'
// Member 'linear_velocity'
#include "geometry_msgs/msg/vector3__traits.hpp"
// Member 'imu_measurements'
#include "halodi_msgs/msg/imu_measurement__traits.hpp"
// Member 'joint_states'
#include "halodi_msgs/msg/joint_measurement__traits.hpp"
// Member 'taskspace_feedback'
#include "halodi_msgs/msg/task_space_feedback__traits.hpp"

namespace rosidl_generator_traits
{

template<>
inline const char * data_type<halodi_msgs::msg::WholeBodyState>()
{
  return "halodi_msgs::msg::WholeBodyState";
}

template<>
struct has_fixed_size<halodi_msgs::msg::WholeBodyState>
  : std::integral_constant<bool, false> {};

template<>
struct has_bounded_size<halodi_msgs::msg::WholeBodyState>
  : std::integral_constant<bool, false> {};

template<>
struct is_message<halodi_msgs::msg::WholeBodyState>
  : std::true_type {};

}  // namespace rosidl_generator_traits

#endif  // HALODI_MSGS__MSG__WHOLE_BODY_STATE__TRAITS_HPP_
