// generated from rosidl_generator_cpp/resource/idl__traits.hpp.em
// with input from halodi_msgs:msg/ExtrinsicCalibrationInfo.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__EXTRINSIC_CALIBRATION_INFO__TRAITS_HPP_
#define HALODI_MSGS__MSG__EXTRINSIC_CALIBRATION_INFO__TRAITS_HPP_

#include "halodi_msgs/msg/extrinsic_calibration_info__struct.hpp"
#include <rosidl_generator_cpp/traits.hpp>
#include <stdint.h>
#include <type_traits>

// Include directives for member types
// Member 'sensor_transforms'
// Member 'link_infos'
#include "geometry_msgs/msg/transform_stamped__traits.hpp"
// Member 'joint_infos'
#include "halodi_msgs/msg/robot_joint_calibration_info__traits.hpp"

namespace rosidl_generator_traits
{

template<>
inline const char * data_type<halodi_msgs::msg::ExtrinsicCalibrationInfo>()
{
  return "halodi_msgs::msg::ExtrinsicCalibrationInfo";
}

template<>
struct has_fixed_size<halodi_msgs::msg::ExtrinsicCalibrationInfo>
  : std::integral_constant<bool, false> {};

template<>
struct has_bounded_size<halodi_msgs::msg::ExtrinsicCalibrationInfo>
  : std::integral_constant<bool, has_bounded_size<geometry_msgs::msg::TransformStamped>::value && has_bounded_size<halodi_msgs::msg::RobotJointCalibrationInfo>::value> {};

template<>
struct is_message<halodi_msgs::msg::ExtrinsicCalibrationInfo>
  : std::true_type {};

}  // namespace rosidl_generator_traits

#endif  // HALODI_MSGS__MSG__EXTRINSIC_CALIBRATION_INFO__TRAITS_HPP_
