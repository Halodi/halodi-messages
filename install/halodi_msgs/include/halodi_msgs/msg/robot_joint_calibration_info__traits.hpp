// generated from rosidl_generator_cpp/resource/idl__traits.hpp.em
// with input from halodi_msgs:msg/RobotJointCalibrationInfo.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__ROBOT_JOINT_CALIBRATION_INFO__TRAITS_HPP_
#define HALODI_MSGS__MSG__ROBOT_JOINT_CALIBRATION_INFO__TRAITS_HPP_

#include "halodi_msgs/msg/robot_joint_calibration_info__struct.hpp"
#include <rosidl_generator_cpp/traits.hpp>
#include <stdint.h>
#include <type_traits>

namespace rosidl_generator_traits
{

template<>
inline const char * data_type<halodi_msgs::msg::RobotJointCalibrationInfo>()
{
  return "halodi_msgs::msg::RobotJointCalibrationInfo";
}

template<>
struct has_fixed_size<halodi_msgs::msg::RobotJointCalibrationInfo>
  : std::integral_constant<bool, false> {};

template<>
struct has_bounded_size<halodi_msgs::msg::RobotJointCalibrationInfo>
  : std::integral_constant<bool, false> {};

template<>
struct is_message<halodi_msgs::msg::RobotJointCalibrationInfo>
  : std::true_type {};

}  // namespace rosidl_generator_traits

#endif  // HALODI_MSGS__MSG__ROBOT_JOINT_CALIBRATION_INFO__TRAITS_HPP_
