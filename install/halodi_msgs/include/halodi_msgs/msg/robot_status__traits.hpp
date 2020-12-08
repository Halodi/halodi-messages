// generated from rosidl_generator_cpp/resource/idl__traits.hpp.em
// with input from halodi_msgs:msg/RobotStatus.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__ROBOT_STATUS__TRAITS_HPP_
#define HALODI_MSGS__MSG__ROBOT_STATUS__TRAITS_HPP_

#include "halodi_msgs/msg/robot_status__struct.hpp"
#include <rosidl_generator_cpp/traits.hpp>
#include <stdint.h>
#include <type_traits>

// Include directives for member types
// Member 'header'
#include "std_msgs/msg/header__traits.hpp"
// Member 'battery_status'
#include "halodi_msgs/msg/battery_status__traits.hpp"
// Member 'joint_status'
#include "halodi_msgs/msg/joint_status__traits.hpp"
// Member 'motor_status'
#include "halodi_msgs/msg/motor_status__traits.hpp"

namespace rosidl_generator_traits
{

template<>
inline const char * data_type<halodi_msgs::msg::RobotStatus>()
{
  return "halodi_msgs::msg::RobotStatus";
}

template<>
struct has_fixed_size<halodi_msgs::msg::RobotStatus>
  : std::integral_constant<bool, false> {};

template<>
struct has_bounded_size<halodi_msgs::msg::RobotStatus>
  : std::integral_constant<bool, has_bounded_size<halodi_msgs::msg::BatteryStatus>::value && has_bounded_size<halodi_msgs::msg::JointStatus>::value && has_bounded_size<halodi_msgs::msg::MotorStatus>::value && has_bounded_size<std_msgs::msg::Header>::value> {};

template<>
struct is_message<halodi_msgs::msg::RobotStatus>
  : std::true_type {};

}  // namespace rosidl_generator_traits

#endif  // HALODI_MSGS__MSG__ROBOT_STATUS__TRAITS_HPP_
