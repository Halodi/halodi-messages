// generated from rosidl_generator_cpp/resource/idl__traits.hpp.em
// with input from halodi_msgs:msg/ImuMeasurement.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__IMU_MEASUREMENT__TRAITS_HPP_
#define HALODI_MSGS__MSG__IMU_MEASUREMENT__TRAITS_HPP_

#include "halodi_msgs/msg/imu_measurement__struct.hpp"
#include <rosidl_generator_cpp/traits.hpp>
#include <stdint.h>
#include <type_traits>

// Include directives for member types
// Member 'imu'
#include "halodi_msgs/msg/imu_name__traits.hpp"
// Member 'orientation'
#include "geometry_msgs/msg/quaternion__traits.hpp"
// Member 'angular_velocity'
// Member 'linear_acceleration'
#include "geometry_msgs/msg/vector3__traits.hpp"

namespace rosidl_generator_traits
{

template<>
inline const char * data_type<halodi_msgs::msg::ImuMeasurement>()
{
  return "halodi_msgs::msg::ImuMeasurement";
}

template<>
struct has_fixed_size<halodi_msgs::msg::ImuMeasurement>
  : std::integral_constant<bool, has_fixed_size<geometry_msgs::msg::Quaternion>::value && has_fixed_size<geometry_msgs::msg::Vector3>::value && has_fixed_size<halodi_msgs::msg::ImuName>::value> {};

template<>
struct has_bounded_size<halodi_msgs::msg::ImuMeasurement>
  : std::integral_constant<bool, has_bounded_size<geometry_msgs::msg::Quaternion>::value && has_bounded_size<geometry_msgs::msg::Vector3>::value && has_bounded_size<halodi_msgs::msg::ImuName>::value> {};

template<>
struct is_message<halodi_msgs::msg::ImuMeasurement>
  : std::true_type {};

}  // namespace rosidl_generator_traits

#endif  // HALODI_MSGS__MSG__IMU_MEASUREMENT__TRAITS_HPP_
