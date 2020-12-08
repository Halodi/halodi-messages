// generated from rosidl_typesupport_introspection_cpp/resource/idl__type_support.cpp.em
// with input from halodi_msgs:msg/FeedbackParameters3D.idl
// generated code does not contain a copyright notice

#include "array"
#include "cstddef"
#include "string"
#include "vector"
#include "rosidl_generator_c/message_type_support_struct.h"
#include "rosidl_typesupport_cpp/message_type_support.hpp"
#include "rosidl_typesupport_interface/macros.h"
#include "halodi_msgs/msg/feedback_parameters3_d__struct.hpp"
#include "rosidl_typesupport_introspection_cpp/field_types.hpp"
#include "rosidl_typesupport_introspection_cpp/identifier.hpp"
#include "rosidl_typesupport_introspection_cpp/message_introspection.hpp"
#include "rosidl_typesupport_introspection_cpp/message_type_support_decl.hpp"
#include "rosidl_typesupport_introspection_cpp/visibility_control.h"

namespace halodi_msgs
{

namespace msg
{

namespace rosidl_typesupport_introspection_cpp
{

void FeedbackParameters3D_init_function(
  void * message_memory, rosidl_generator_cpp::MessageInitialization _init)
{
  new (message_memory) halodi_msgs::msg::FeedbackParameters3D(_init);
}

void FeedbackParameters3D_fini_function(void * message_memory)
{
  auto typed_message = static_cast<halodi_msgs::msg::FeedbackParameters3D *>(message_memory);
  typed_message->~FeedbackParameters3D();
}

size_t size_function__FeedbackParameters3D__integral(const void * untyped_member)
{
  const auto * member = reinterpret_cast<const std::vector<geometry_msgs::msg::Vector3> *>(untyped_member);
  return member->size();
}

const void * get_const_function__FeedbackParameters3D__integral(const void * untyped_member, size_t index)
{
  const auto & member =
    *reinterpret_cast<const std::vector<geometry_msgs::msg::Vector3> *>(untyped_member);
  return &member[index];
}

void * get_function__FeedbackParameters3D__integral(void * untyped_member, size_t index)
{
  auto & member =
    *reinterpret_cast<std::vector<geometry_msgs::msg::Vector3> *>(untyped_member);
  return &member[index];
}

void resize_function__FeedbackParameters3D__integral(void * untyped_member, size_t size)
{
  auto * member =
    reinterpret_cast<std::vector<geometry_msgs::msg::Vector3> *>(untyped_member);
  member->resize(size);
}

size_t size_function__FeedbackParameters3D__maximum_proportional_error(const void * untyped_member)
{
  const auto * member = reinterpret_cast<const std::vector<double> *>(untyped_member);
  return member->size();
}

const void * get_const_function__FeedbackParameters3D__maximum_proportional_error(const void * untyped_member, size_t index)
{
  const auto & member =
    *reinterpret_cast<const std::vector<double> *>(untyped_member);
  return &member[index];
}

void * get_function__FeedbackParameters3D__maximum_proportional_error(void * untyped_member, size_t index)
{
  auto & member =
    *reinterpret_cast<std::vector<double> *>(untyped_member);
  return &member[index];
}

void resize_function__FeedbackParameters3D__maximum_proportional_error(void * untyped_member, size_t size)
{
  auto * member =
    reinterpret_cast<std::vector<double> *>(untyped_member);
  member->resize(size);
}

size_t size_function__FeedbackParameters3D__maximum_integral_windup(const void * untyped_member)
{
  const auto * member = reinterpret_cast<const std::vector<double> *>(untyped_member);
  return member->size();
}

const void * get_const_function__FeedbackParameters3D__maximum_integral_windup(const void * untyped_member, size_t index)
{
  const auto & member =
    *reinterpret_cast<const std::vector<double> *>(untyped_member);
  return &member[index];
}

void * get_function__FeedbackParameters3D__maximum_integral_windup(void * untyped_member, size_t index)
{
  auto & member =
    *reinterpret_cast<std::vector<double> *>(untyped_member);
  return &member[index];
}

void resize_function__FeedbackParameters3D__maximum_integral_windup(void * untyped_member, size_t size)
{
  auto * member =
    reinterpret_cast<std::vector<double> *>(untyped_member);
  member->resize(size);
}

size_t size_function__FeedbackParameters3D__maximum_derivative_error(const void * untyped_member)
{
  const auto * member = reinterpret_cast<const std::vector<double> *>(untyped_member);
  return member->size();
}

const void * get_const_function__FeedbackParameters3D__maximum_derivative_error(const void * untyped_member, size_t index)
{
  const auto & member =
    *reinterpret_cast<const std::vector<double> *>(untyped_member);
  return &member[index];
}

void * get_function__FeedbackParameters3D__maximum_derivative_error(void * untyped_member, size_t index)
{
  auto & member =
    *reinterpret_cast<std::vector<double> *>(untyped_member);
  return &member[index];
}

void resize_function__FeedbackParameters3D__maximum_derivative_error(void * untyped_member, size_t size)
{
  auto * member =
    reinterpret_cast<std::vector<double> *>(untyped_member);
  member->resize(size);
}

size_t size_function__FeedbackParameters3D__maximum_feedback(const void * untyped_member)
{
  const auto * member = reinterpret_cast<const std::vector<double> *>(untyped_member);
  return member->size();
}

const void * get_const_function__FeedbackParameters3D__maximum_feedback(const void * untyped_member, size_t index)
{
  const auto & member =
    *reinterpret_cast<const std::vector<double> *>(untyped_member);
  return &member[index];
}

void * get_function__FeedbackParameters3D__maximum_feedback(void * untyped_member, size_t index)
{
  auto & member =
    *reinterpret_cast<std::vector<double> *>(untyped_member);
  return &member[index];
}

void resize_function__FeedbackParameters3D__maximum_feedback(void * untyped_member, size_t size)
{
  auto * member =
    reinterpret_cast<std::vector<double> *>(untyped_member);
  member->resize(size);
}

size_t size_function__FeedbackParameters3D__maximum_feedback_rate(const void * untyped_member)
{
  const auto * member = reinterpret_cast<const std::vector<double> *>(untyped_member);
  return member->size();
}

const void * get_const_function__FeedbackParameters3D__maximum_feedback_rate(const void * untyped_member, size_t index)
{
  const auto & member =
    *reinterpret_cast<const std::vector<double> *>(untyped_member);
  return &member[index];
}

void * get_function__FeedbackParameters3D__maximum_feedback_rate(void * untyped_member, size_t index)
{
  auto & member =
    *reinterpret_cast<std::vector<double> *>(untyped_member);
  return &member[index];
}

void resize_function__FeedbackParameters3D__maximum_feedback_rate(void * untyped_member, size_t size)
{
  auto * member =
    reinterpret_cast<std::vector<double> *>(untyped_member);
  member->resize(size);
}

size_t size_function__FeedbackParameters3D__integral_leakage(const void * untyped_member)
{
  const auto * member = reinterpret_cast<const std::vector<double> *>(untyped_member);
  return member->size();
}

const void * get_const_function__FeedbackParameters3D__integral_leakage(const void * untyped_member, size_t index)
{
  const auto & member =
    *reinterpret_cast<const std::vector<double> *>(untyped_member);
  return &member[index];
}

void * get_function__FeedbackParameters3D__integral_leakage(void * untyped_member, size_t index)
{
  auto & member =
    *reinterpret_cast<std::vector<double> *>(untyped_member);
  return &member[index];
}

void resize_function__FeedbackParameters3D__integral_leakage(void * untyped_member, size_t size)
{
  auto * member =
    reinterpret_cast<std::vector<double> *>(untyped_member);
  member->resize(size);
}

static const ::rosidl_typesupport_introspection_cpp::MessageMember FeedbackParameters3D_message_member_array[9] = {
  {
    "proportional",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    ::rosidl_typesupport_introspection_cpp::get_message_type_support_handle<geometry_msgs::msg::Vector3>(),  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs::msg::FeedbackParameters3D, proportional),  // bytes offset in struct
    nullptr,  // default value
    nullptr,  // size() function pointer
    nullptr,  // get_const(index) function pointer
    nullptr,  // get(index) function pointer
    nullptr  // resize(index) function pointer
  },
  {
    "integral",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    ::rosidl_typesupport_introspection_cpp::get_message_type_support_handle<geometry_msgs::msg::Vector3>(),  // members of sub message
    true,  // is array
    1,  // array size
    true,  // is upper bound
    offsetof(halodi_msgs::msg::FeedbackParameters3D, integral),  // bytes offset in struct
    nullptr,  // default value
    size_function__FeedbackParameters3D__integral,  // size() function pointer
    get_const_function__FeedbackParameters3D__integral,  // get_const(index) function pointer
    get_function__FeedbackParameters3D__integral,  // get(index) function pointer
    resize_function__FeedbackParameters3D__integral  // resize(index) function pointer
  },
  {
    "derivative",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    ::rosidl_typesupport_introspection_cpp::get_message_type_support_handle<geometry_msgs::msg::Vector3>(),  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs::msg::FeedbackParameters3D, derivative),  // bytes offset in struct
    nullptr,  // default value
    nullptr,  // size() function pointer
    nullptr,  // get_const(index) function pointer
    nullptr,  // get(index) function pointer
    nullptr  // resize(index) function pointer
  },
  {
    "maximum_proportional_error",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_DOUBLE,  // type
    0,  // upper bound of string
    nullptr,  // members of sub message
    true,  // is array
    1,  // array size
    true,  // is upper bound
    offsetof(halodi_msgs::msg::FeedbackParameters3D, maximum_proportional_error),  // bytes offset in struct
    nullptr,  // default value
    size_function__FeedbackParameters3D__maximum_proportional_error,  // size() function pointer
    get_const_function__FeedbackParameters3D__maximum_proportional_error,  // get_const(index) function pointer
    get_function__FeedbackParameters3D__maximum_proportional_error,  // get(index) function pointer
    resize_function__FeedbackParameters3D__maximum_proportional_error  // resize(index) function pointer
  },
  {
    "maximum_integral_windup",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_DOUBLE,  // type
    0,  // upper bound of string
    nullptr,  // members of sub message
    true,  // is array
    1,  // array size
    true,  // is upper bound
    offsetof(halodi_msgs::msg::FeedbackParameters3D, maximum_integral_windup),  // bytes offset in struct
    nullptr,  // default value
    size_function__FeedbackParameters3D__maximum_integral_windup,  // size() function pointer
    get_const_function__FeedbackParameters3D__maximum_integral_windup,  // get_const(index) function pointer
    get_function__FeedbackParameters3D__maximum_integral_windup,  // get(index) function pointer
    resize_function__FeedbackParameters3D__maximum_integral_windup  // resize(index) function pointer
  },
  {
    "maximum_derivative_error",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_DOUBLE,  // type
    0,  // upper bound of string
    nullptr,  // members of sub message
    true,  // is array
    1,  // array size
    true,  // is upper bound
    offsetof(halodi_msgs::msg::FeedbackParameters3D, maximum_derivative_error),  // bytes offset in struct
    nullptr,  // default value
    size_function__FeedbackParameters3D__maximum_derivative_error,  // size() function pointer
    get_const_function__FeedbackParameters3D__maximum_derivative_error,  // get_const(index) function pointer
    get_function__FeedbackParameters3D__maximum_derivative_error,  // get(index) function pointer
    resize_function__FeedbackParameters3D__maximum_derivative_error  // resize(index) function pointer
  },
  {
    "maximum_feedback",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_DOUBLE,  // type
    0,  // upper bound of string
    nullptr,  // members of sub message
    true,  // is array
    1,  // array size
    true,  // is upper bound
    offsetof(halodi_msgs::msg::FeedbackParameters3D, maximum_feedback),  // bytes offset in struct
    nullptr,  // default value
    size_function__FeedbackParameters3D__maximum_feedback,  // size() function pointer
    get_const_function__FeedbackParameters3D__maximum_feedback,  // get_const(index) function pointer
    get_function__FeedbackParameters3D__maximum_feedback,  // get(index) function pointer
    resize_function__FeedbackParameters3D__maximum_feedback  // resize(index) function pointer
  },
  {
    "maximum_feedback_rate",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_DOUBLE,  // type
    0,  // upper bound of string
    nullptr,  // members of sub message
    true,  // is array
    1,  // array size
    true,  // is upper bound
    offsetof(halodi_msgs::msg::FeedbackParameters3D, maximum_feedback_rate),  // bytes offset in struct
    nullptr,  // default value
    size_function__FeedbackParameters3D__maximum_feedback_rate,  // size() function pointer
    get_const_function__FeedbackParameters3D__maximum_feedback_rate,  // get_const(index) function pointer
    get_function__FeedbackParameters3D__maximum_feedback_rate,  // get(index) function pointer
    resize_function__FeedbackParameters3D__maximum_feedback_rate  // resize(index) function pointer
  },
  {
    "integral_leakage",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_DOUBLE,  // type
    0,  // upper bound of string
    nullptr,  // members of sub message
    true,  // is array
    1,  // array size
    true,  // is upper bound
    offsetof(halodi_msgs::msg::FeedbackParameters3D, integral_leakage),  // bytes offset in struct
    nullptr,  // default value
    size_function__FeedbackParameters3D__integral_leakage,  // size() function pointer
    get_const_function__FeedbackParameters3D__integral_leakage,  // get_const(index) function pointer
    get_function__FeedbackParameters3D__integral_leakage,  // get(index) function pointer
    resize_function__FeedbackParameters3D__integral_leakage  // resize(index) function pointer
  }
};

static const ::rosidl_typesupport_introspection_cpp::MessageMembers FeedbackParameters3D_message_members = {
  "halodi_msgs::msg",  // message namespace
  "FeedbackParameters3D",  // message name
  9,  // number of fields
  sizeof(halodi_msgs::msg::FeedbackParameters3D),
  FeedbackParameters3D_message_member_array,  // message members
  FeedbackParameters3D_init_function,  // function to initialize message memory (memory has to be allocated)
  FeedbackParameters3D_fini_function  // function to terminate message instance (will not free memory)
};

static const rosidl_message_type_support_t FeedbackParameters3D_message_type_support_handle = {
  ::rosidl_typesupport_introspection_cpp::typesupport_identifier,
  &FeedbackParameters3D_message_members,
  get_message_typesupport_handle_function,
};

}  // namespace rosidl_typesupport_introspection_cpp

}  // namespace msg

}  // namespace halodi_msgs


namespace rosidl_typesupport_introspection_cpp
{

template<>
ROSIDL_TYPESUPPORT_INTROSPECTION_CPP_PUBLIC
const rosidl_message_type_support_t *
get_message_type_support_handle<halodi_msgs::msg::FeedbackParameters3D>()
{
  return &::halodi_msgs::msg::rosidl_typesupport_introspection_cpp::FeedbackParameters3D_message_type_support_handle;
}

}  // namespace rosidl_typesupport_introspection_cpp

#ifdef __cplusplus
extern "C"
{
#endif

ROSIDL_TYPESUPPORT_INTROSPECTION_CPP_PUBLIC
const rosidl_message_type_support_t *
ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_cpp, halodi_msgs, msg, FeedbackParameters3D)() {
  return &::halodi_msgs::msg::rosidl_typesupport_introspection_cpp::FeedbackParameters3D_message_type_support_handle;
}

#ifdef __cplusplus
}
#endif
