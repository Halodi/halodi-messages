// generated from rosidl_typesupport_introspection_cpp/resource/idl__type_support.cpp.em
// with input from halodi_msgs:msg/WholeBodyTrajectory.idl
// generated code does not contain a copyright notice

#include "array"
#include "cstddef"
#include "string"
#include "vector"
#include "rosidl_generator_c/message_type_support_struct.h"
#include "rosidl_typesupport_cpp/message_type_support.hpp"
#include "rosidl_typesupport_interface/macros.h"
#include "halodi_msgs/msg/whole_body_trajectory__struct.hpp"
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

void WholeBodyTrajectory_init_function(
  void * message_memory, rosidl_generator_cpp::MessageInitialization _init)
{
  new (message_memory) halodi_msgs::msg::WholeBodyTrajectory(_init);
}

void WholeBodyTrajectory_fini_function(void * message_memory)
{
  auto typed_message = static_cast<halodi_msgs::msg::WholeBodyTrajectory *>(message_memory);
  typed_message->~WholeBodyTrajectory();
}

size_t size_function__WholeBodyTrajectory__start_time(const void * untyped_member)
{
  const auto * member = reinterpret_cast<const std::vector<builtin_interfaces::msg::Time> *>(untyped_member);
  return member->size();
}

const void * get_const_function__WholeBodyTrajectory__start_time(const void * untyped_member, size_t index)
{
  const auto & member =
    *reinterpret_cast<const std::vector<builtin_interfaces::msg::Time> *>(untyped_member);
  return &member[index];
}

void * get_function__WholeBodyTrajectory__start_time(void * untyped_member, size_t index)
{
  auto & member =
    *reinterpret_cast<std::vector<builtin_interfaces::msg::Time> *>(untyped_member);
  return &member[index];
}

void resize_function__WholeBodyTrajectory__start_time(void * untyped_member, size_t size)
{
  auto * member =
    reinterpret_cast<std::vector<builtin_interfaces::msg::Time> *>(untyped_member);
  member->resize(size);
}

size_t size_function__WholeBodyTrajectory__balance_mode(const void * untyped_member)
{
  const auto * member = reinterpret_cast<const std::vector<halodi_msgs::msg::BalanceMode> *>(untyped_member);
  return member->size();
}

const void * get_const_function__WholeBodyTrajectory__balance_mode(const void * untyped_member, size_t index)
{
  const auto & member =
    *reinterpret_cast<const std::vector<halodi_msgs::msg::BalanceMode> *>(untyped_member);
  return &member[index];
}

void * get_function__WholeBodyTrajectory__balance_mode(void * untyped_member, size_t index)
{
  auto & member =
    *reinterpret_cast<std::vector<halodi_msgs::msg::BalanceMode> *>(untyped_member);
  return &member[index];
}

void resize_function__WholeBodyTrajectory__balance_mode(void * untyped_member, size_t size)
{
  auto * member =
    reinterpret_cast<std::vector<halodi_msgs::msg::BalanceMode> *>(untyped_member);
  member->resize(size);
}

size_t size_function__WholeBodyTrajectory__trajectory_points(const void * untyped_member)
{
  const auto * member = reinterpret_cast<const std::vector<halodi_msgs::msg::WholeBodyTrajectoryPoint> *>(untyped_member);
  return member->size();
}

const void * get_const_function__WholeBodyTrajectory__trajectory_points(const void * untyped_member, size_t index)
{
  const auto & member =
    *reinterpret_cast<const std::vector<halodi_msgs::msg::WholeBodyTrajectoryPoint> *>(untyped_member);
  return &member[index];
}

void * get_function__WholeBodyTrajectory__trajectory_points(void * untyped_member, size_t index)
{
  auto & member =
    *reinterpret_cast<std::vector<halodi_msgs::msg::WholeBodyTrajectoryPoint> *>(untyped_member);
  return &member[index];
}

void resize_function__WholeBodyTrajectory__trajectory_points(void * untyped_member, size_t size)
{
  auto * member =
    reinterpret_cast<std::vector<halodi_msgs::msg::WholeBodyTrajectoryPoint> *>(untyped_member);
  member->resize(size);
}

static const ::rosidl_typesupport_introspection_cpp::MessageMember WholeBodyTrajectory_message_member_array[6] = {
  {
    "trajectory_id",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    ::rosidl_typesupport_introspection_cpp::get_message_type_support_handle<unique_identifier_msgs::msg::UUID>(),  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs::msg::WholeBodyTrajectory, trajectory_id),  // bytes offset in struct
    nullptr,  // default value
    nullptr,  // size() function pointer
    nullptr,  // get_const(index) function pointer
    nullptr,  // get(index) function pointer
    nullptr  // resize(index) function pointer
  },
  {
    "start_time",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    ::rosidl_typesupport_introspection_cpp::get_message_type_support_handle<builtin_interfaces::msg::Time>(),  // members of sub message
    true,  // is array
    1,  // array size
    true,  // is upper bound
    offsetof(halodi_msgs::msg::WholeBodyTrajectory, start_time),  // bytes offset in struct
    nullptr,  // default value
    size_function__WholeBodyTrajectory__start_time,  // size() function pointer
    get_const_function__WholeBodyTrajectory__start_time,  // get_const(index) function pointer
    get_function__WholeBodyTrajectory__start_time,  // get(index) function pointer
    resize_function__WholeBodyTrajectory__start_time  // resize(index) function pointer
  },
  {
    "balance_mode",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    ::rosidl_typesupport_introspection_cpp::get_message_type_support_handle<halodi_msgs::msg::BalanceMode>(),  // members of sub message
    true,  // is array
    1,  // array size
    true,  // is upper bound
    offsetof(halodi_msgs::msg::WholeBodyTrajectory, balance_mode),  // bytes offset in struct
    nullptr,  // default value
    size_function__WholeBodyTrajectory__balance_mode,  // size() function pointer
    get_const_function__WholeBodyTrajectory__balance_mode,  // get_const(index) function pointer
    get_function__WholeBodyTrajectory__balance_mode,  // get(index) function pointer
    resize_function__WholeBodyTrajectory__balance_mode  // resize(index) function pointer
  },
  {
    "append_trajectory",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_BOOLEAN,  // type
    0,  // upper bound of string
    nullptr,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs::msg::WholeBodyTrajectory, append_trajectory),  // bytes offset in struct
    nullptr,  // default value
    nullptr,  // size() function pointer
    nullptr,  // get_const(index) function pointer
    nullptr,  // get(index) function pointer
    nullptr  // resize(index) function pointer
  },
  {
    "interpolation_mode",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    ::rosidl_typesupport_introspection_cpp::get_message_type_support_handle<halodi_msgs::msg::TrajectoryInterpolation>(),  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs::msg::WholeBodyTrajectory, interpolation_mode),  // bytes offset in struct
    nullptr,  // default value
    nullptr,  // size() function pointer
    nullptr,  // get_const(index) function pointer
    nullptr,  // get(index) function pointer
    nullptr  // resize(index) function pointer
  },
  {
    "trajectory_points",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    ::rosidl_typesupport_introspection_cpp::get_message_type_support_handle<halodi_msgs::msg::WholeBodyTrajectoryPoint>(),  // members of sub message
    true,  // is array
    255,  // array size
    true,  // is upper bound
    offsetof(halodi_msgs::msg::WholeBodyTrajectory, trajectory_points),  // bytes offset in struct
    nullptr,  // default value
    size_function__WholeBodyTrajectory__trajectory_points,  // size() function pointer
    get_const_function__WholeBodyTrajectory__trajectory_points,  // get_const(index) function pointer
    get_function__WholeBodyTrajectory__trajectory_points,  // get(index) function pointer
    resize_function__WholeBodyTrajectory__trajectory_points  // resize(index) function pointer
  }
};

static const ::rosidl_typesupport_introspection_cpp::MessageMembers WholeBodyTrajectory_message_members = {
  "halodi_msgs::msg",  // message namespace
  "WholeBodyTrajectory",  // message name
  6,  // number of fields
  sizeof(halodi_msgs::msg::WholeBodyTrajectory),
  WholeBodyTrajectory_message_member_array,  // message members
  WholeBodyTrajectory_init_function,  // function to initialize message memory (memory has to be allocated)
  WholeBodyTrajectory_fini_function  // function to terminate message instance (will not free memory)
};

static const rosidl_message_type_support_t WholeBodyTrajectory_message_type_support_handle = {
  ::rosidl_typesupport_introspection_cpp::typesupport_identifier,
  &WholeBodyTrajectory_message_members,
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
get_message_type_support_handle<halodi_msgs::msg::WholeBodyTrajectory>()
{
  return &::halodi_msgs::msg::rosidl_typesupport_introspection_cpp::WholeBodyTrajectory_message_type_support_handle;
}

}  // namespace rosidl_typesupport_introspection_cpp

#ifdef __cplusplus
extern "C"
{
#endif

ROSIDL_TYPESUPPORT_INTROSPECTION_CPP_PUBLIC
const rosidl_message_type_support_t *
ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_cpp, halodi_msgs, msg, WholeBodyTrajectory)() {
  return &::halodi_msgs::msg::rosidl_typesupport_introspection_cpp::WholeBodyTrajectory_message_type_support_handle;
}

#ifdef __cplusplus
}
#endif
