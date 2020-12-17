// generated from rosidl_generator_cpp/resource/idl__traits.hpp.em
// with input from halodi_msgs:srv/GetStampedTF.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__SRV__GET_STAMPED_TF__TRAITS_HPP_
#define HALODI_MSGS__SRV__GET_STAMPED_TF__TRAITS_HPP_

#include "halodi_msgs/srv/get_stamped_tf__struct.hpp"
#include <rosidl_generator_cpp/traits.hpp>
#include <stdint.h>
#include <type_traits>

namespace rosidl_generator_traits
{

template<>
inline const char * data_type<halodi_msgs::srv::GetStampedTF_Request>()
{
  return "halodi_msgs::srv::GetStampedTF_Request";
}

template<>
struct has_fixed_size<halodi_msgs::srv::GetStampedTF_Request>
  : std::integral_constant<bool, false> {};

template<>
struct has_bounded_size<halodi_msgs::srv::GetStampedTF_Request>
  : std::integral_constant<bool, false> {};

template<>
struct is_message<halodi_msgs::srv::GetStampedTF_Request>
  : std::true_type {};

}  // namespace rosidl_generator_traits

// Include directives for member types
// Member 'stf'
#include "geometry_msgs/msg/transform_stamped__traits.hpp"

namespace rosidl_generator_traits
{

template<>
inline const char * data_type<halodi_msgs::srv::GetStampedTF_Response>()
{
  return "halodi_msgs::srv::GetStampedTF_Response";
}

template<>
struct has_fixed_size<halodi_msgs::srv::GetStampedTF_Response>
  : std::integral_constant<bool, has_fixed_size<geometry_msgs::msg::TransformStamped>::value> {};

template<>
struct has_bounded_size<halodi_msgs::srv::GetStampedTF_Response>
  : std::integral_constant<bool, has_bounded_size<geometry_msgs::msg::TransformStamped>::value> {};

template<>
struct is_message<halodi_msgs::srv::GetStampedTF_Response>
  : std::true_type {};

}  // namespace rosidl_generator_traits

namespace rosidl_generator_traits
{

template<>
inline const char * data_type<halodi_msgs::srv::GetStampedTF>()
{
  return "halodi_msgs::srv::GetStampedTF";
}

template<>
struct has_fixed_size<halodi_msgs::srv::GetStampedTF>
  : std::integral_constant<
    bool,
    has_fixed_size<halodi_msgs::srv::GetStampedTF_Request>::value &&
    has_fixed_size<halodi_msgs::srv::GetStampedTF_Response>::value
  >
{
};

template<>
struct has_bounded_size<halodi_msgs::srv::GetStampedTF>
  : std::integral_constant<
    bool,
    has_bounded_size<halodi_msgs::srv::GetStampedTF_Request>::value &&
    has_bounded_size<halodi_msgs::srv::GetStampedTF_Response>::value
  >
{
};

template<>
struct is_service<halodi_msgs::srv::GetStampedTF>
  : std::true_type
{
};

template<>
struct is_service_request<halodi_msgs::srv::GetStampedTF_Request>
  : std::true_type
{
};

template<>
struct is_service_response<halodi_msgs::srv::GetStampedTF_Response>
  : std::true_type
{
};

}  // namespace rosidl_generator_traits

#endif  // HALODI_MSGS__SRV__GET_STAMPED_TF__TRAITS_HPP_
